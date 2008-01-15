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

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long state = 13;
            foreach (long value in data)
            {
                if ((double)seed < (double)value)
                {
                    state = state + (seed - state);
                }
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state & 127)) % 65521;
            }
            return state % 1000;
        }
    }
}
