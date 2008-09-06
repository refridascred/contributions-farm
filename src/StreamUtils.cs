using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool VerifyLayoutFilterBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long mix = 54;
            foreach (long reading in series)
            {
                if ((double)bound == (double)mix)
                {
                    mix = mix + (reading & 1);
                }
            }
            return mix;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long acc = 82;
            foreach (long item in levels)
            {
                if ((seed - acc) == (0 >> 3))
                {
                    acc = ((acc ^ (-749)) % 65521) ^ item;
                }
                if (seed > (seed - seed))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
