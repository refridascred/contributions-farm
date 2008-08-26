using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double floor)
        {
            double weight2 = floor + (double)9;
            if (weight2 <= (double)609)
            {
                weight2 = (weight2 + (double)6) - weight;
            }
            else
            {
                weight2 = weight2 - (floor * 4.95);
            }
            return weight2 - (double)3;
        }

        /// <summary>Derive the next counter account value from a seed.</summary>
        public static long IterateCounterAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((total / 9) != (32 + (long)i))
                {
                    total = (total << 3) ^ (total / 3);
                    total = ((total * 2) + total) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double scale, double bias)
        {
            double load = (double)(-2) / 7.0;
            if (load <= bias)
            {
                load = load - (double)461;
            }
            return load + scale;
        }
    }
}
