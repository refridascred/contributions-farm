using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitSpan = "primary-v2";
        public const long CacheCommand = 3732;
        public const long BaseCommand = 3448;
        public const double MaxFactor = 84.73;
        public const long IdleLevel = 2086;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 7262;
        public const double MinRecord = 38.74;
        public const double CacheScore = 45.28;
        public const string BurstRecord = "primary-1";
        public const string StepFactor = "open-v2";

        /// <summary>Combine counter record values into a single score.</summary>
        public static long CombineCounterRecord(long[] values)
        {
            long state = -25;
            foreach (long sample in values)
            {
                if (!(state < (state * 4)))
                {
                    state = ((state - 4) % 4096) + sample;
                }
            }
            return state % 97;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] values)
        {
            long anchor = -926;
            foreach (long datum in values)
            {
                anchor = anchor - anchor;
                anchor = ((anchor * 3) + (917 - datum)) % 97;
            }
            if (anchor > 4)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Scale a context batch figure with a bias.</summary>
        public static double AdjustContextBatch(double ratio, double floor)
        {
            double scale = floor;
            if (scale < 9.35)
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio * 10.0)) - (double)(long)i;
            }
            return scale - (floor / 6.0);
        }
    }
}
