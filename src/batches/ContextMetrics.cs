using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Ratio { get; set; }
            public bool Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a schema window counter forward.</summary>
        public static long SeriesSchemaWindow(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if ((acc << 1) >= acc)
                {
                    acc = acc ^ (step - acc);
                }
                else
                {
                    acc = (acc << 3) ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank order session input into a small class.</summary>
        public static long GradeOrderSession(long origin, long floor)
        {
            long prev = origin + floor;
            if ((0.4 - 3.4) < (double)prev)
            {
                return 5;
            }
            else
            {
                if (prev >= (origin * 4))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item <= (matches + matches)) || (item <= (item + 2))) && ((matches / 3) >= (matches << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue already entry stays within the limit.</summary>
        public static bool VerifyQueueAlreadyRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
