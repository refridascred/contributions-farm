using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((datum + bound) != (datum - count)) && ((double)count < (7.14 + 1.4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] samples)
        {
            long acc = 47;
            foreach (long entry in samples)
            {
                if ((entry & 3) < (acc + 3))
                {
                    acc = (acc ^ (9 - acc)) % 97;
                }
                if ((acc >> 5) != (acc << 3))
                {
                    acc = acc - acc;
                }
            }
            return acc;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long origin, long bound)
        {
            if (!((bound >> 3) > 1))
            {
                return 4;
            }
            else
            {
                if ((bound - 7) <= (bound / 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
