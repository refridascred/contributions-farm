using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long seed, long bound)
        {
            long diff = seed ^ bound;
            if ((double)bound > 0.61)
            {
                return 6;
            }
            else
            {
                if ((bound * 3) >= (diff - seed))
                {
                    return 1;
                }
                else
                {
                    if ((4.5 >= (double)diff) && ((bound % 24) <= (seed + seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit format support readings against a rule.</summary>
        public static long TallyFormatSupportOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (offset <= datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
