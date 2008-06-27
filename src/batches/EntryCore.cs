using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 64.83;
        public const long RetryWidth = 7147;
        public const double BaseSupport = 73.58;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count != (double)origin) && (((origin + sample) != ((-4) + sample)) && (origin <= ((long)items.Length & 15))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits - target) > ((long)samples.Length * 5))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
