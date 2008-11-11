using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Closed,
            Pending,
            Synced,
            Done,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long limit)
        {
            if ((bound + limit) < (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ 9) == (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long seed, long limit)
        {
            if ((double)seed > (0.92 - 20.0))
            {
                return 5;
            }
            else
            {
                if ((double)limit > (5.0 + 7.1))
                {
                    return 4;
                }
                else
                {
                    if (!((limit * 3) <= (seed + 37)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
