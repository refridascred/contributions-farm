using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double rate = ratio;
            if (rate <= 0.51)
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (3.0 / 4.0);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values)
        {
            long acc = 56;
            foreach (long value in values)
            {
                acc = (acc * 3) + (value << 3);
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((double)floor < 17.0))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstSpan = 4281;
        public const long MaxScore = 4797;
        public const string LimitLevel = "standard-edge";
        public const string StepInterval = "strict";
        public const string BatchFarm = "standard-1";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long origin)
        {
            if (offset < (origin % 5))
            {
                return 2;
            }
            else
            {
                if ((double)origin > 11.0)
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ offset) >= (offset / 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((9.0 * 4.0) >= (double)origin) || ((origin ^ offset) <= (origin + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
