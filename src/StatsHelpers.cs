using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double gain = (double)((-51) - 9);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)57) + (double)(long)i) - bias;
            }
            return gain - (rate - 6.96);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((seed2 - 58) <= (seed + seed2))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (4.14 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((909 + seed) < (edge + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            New,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 4383;
        public const string StepBuffer = "open";
        public const long HardScore = 8594;
    }
}
