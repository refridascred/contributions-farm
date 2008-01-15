using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double bias)
        {
            double drift = (8.0 - bias) + bias;
            if (drift <= (double)0)
            {
                drift = (drift - (drift + bias)) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Iterate the already account series from a seed.</summary>
        public static long RollAlreadyAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((total / 4) < (total >> 4))
                {
                    total = total - (14 / 6);
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    total = ((total + (total << 3)) % 97) ^ (long)i2;
                    total = (total - (long)i) % 65521;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
