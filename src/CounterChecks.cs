using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the contributi graph entries that pass the check.</summary>
        public static long CountContributiGraphMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell ^ cell) != (tally + 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double bias)
        {
            double gain = scale;
            return (gain + (gain + scale)) + bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Active,
            Locked,
            Closed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 8538;
        public const long StepLevel = 77;
        public const double CacheContext = 48.05;
        public const long BurstRatio = 9707;

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                mix = (mix << 3) ^ (reading + 263);
                if (!(((reading - mix) < (mix % 10)) && ((0.72 + 2.6) == (double)reading)))
                {
                    mix = ((mix << 3) ^ (180 / 9)) % 255;
                }
                mix = (mix << 2) ^ (mix >> 4);
            }
            if (mix < 90)
            {
                mix = (mix + (mix << 3)) % 101;
            }
            return mix % 4096;
        }
    }
}
