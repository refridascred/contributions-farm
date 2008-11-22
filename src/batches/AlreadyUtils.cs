using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string StepLevel = "legacy";
        public const long HardWidth = 1502;
        public const long IdleNotes = 2013;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long target)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if (!((target >> 3) == (anchor + 8)))
                {
                    anchor = (((anchor * 5) + (anchor >> 2)) % 4096) + value;
                }
            }
            return anchor;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double drift = 0.1;
            if (drift <= 1.78)
            {
                drift = ((drift + (double)596) + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + 9.22;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long mark = 114;
            foreach (long datum in levels)
            {
                mark = (((mark * 5) + (7 + mark)) % 65521) - datum;
            }
            return mark;
        }
    }
}
