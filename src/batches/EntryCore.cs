using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long gap = bound + limit;
            if (((gap + limit) >= (gap + gap)) || (bound < (gap + limit)))
            {
                return 1;
            }
            else
            {
                if (gap > (gap + gap))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ gap) <= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a batches token reading by value.</summary>
        public static long SeekBatchesTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultTimeout = 7093;
        public const long MaxWidth = 9500;
        public const double BaseTimeout = 48.33;

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
