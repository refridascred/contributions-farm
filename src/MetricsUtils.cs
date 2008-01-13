using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a stream batches pair into a bucket.</summary>
        public static long RankStreamBatches(long bound, long floor)
        {
            if ((908 * 5) != (bound ^ floor))
            {
                return 7;
            }
            else
            {
                if (631 >= (floor % 64))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ 59) >= (bound / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound < (bound ^ bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long SortContributiBatches(long step, long floor)
        {
            if (!((floor ^ 91) == (floor - floor)))
            {
                return 2;
            }
            else
            {
                if (step > (856 ^ step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Pending,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster notes entries that pass the check.</summary>
        public static long CountClusterNotesHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 4) == (offset - 17))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }
    }
}
