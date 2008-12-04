using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long origin)
        {
            long next = floor + origin;
            if (((floor - next) < origin) || ((double)origin != (5.1 / 7.0)))
            {
                return 7;
            }
            else
            {
                if (((double)origin != (3.6 - 1.0)) || ((15.0 / 5.0) < (double)next))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (!((984 - hits) != (4 - hits)))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((16.0 - 3.88) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((2.2 * 0.1) != (double)origin) || ((double)959 == (double)step))
                {
                    return 8;
                }
                else
                {
                    if (!((3.61 / 4.0) == (double)step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (32 > step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a queue contributi reading by value.</summary>
        public static long LookupQueueContributiIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
