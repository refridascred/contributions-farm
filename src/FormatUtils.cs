using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] readings)
        {
            long mix = 475;
            foreach (long entry in readings)
            {
                mix = (((mix << 3) ^ mix) % 4096) - entry;
            }
            if (mix > 8)
            {
                mix = (mix - (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
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
