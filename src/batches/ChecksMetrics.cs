using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long offset, long bound)
        {
            long step = offset + bound;
            if ((step + step) > (95 - offset))
            {
                return 4;
            }
            else
            {
                if ((13.0 - 6.89) <= (double)step)
                {
                    return 8;
                }
                else
                {
                    if (((7 + step) > (bound - offset)) || ((bound - step) > (bound / 6)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Retry,
            Synced,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                if (acc < (offset - 65))
                {
                    acc = acc ^ (acc & 63);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the session batch entries that pass the check.</summary>
        public static long TallySessionBatchGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry < (85 + count))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
