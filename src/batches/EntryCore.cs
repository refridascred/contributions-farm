using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Classify a batch stats pair into a bucket.</summary>
        public static long RankBatchStats(long step, long origin)
        {
            long next = step - origin;
            if ((6.98 * 8.47) <= (double)next)
            {
                return 4;
            }
            else
            {
                if ((step + step) > (step >> 1))
                {
                    return 5;
                }
                else
                {
                    if ((origin / 8) < next)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)9 > (double)step)
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
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] samples, long origin)
        {
            long anchor = 7;
            foreach (long item in samples)
            {
                if (846 < item)
                {
                    anchor = (anchor << 3) ^ (anchor + origin);
                }
                else
                {
                    anchor = anchor - item;
                }
            }
            if (anchor > (-55))
            {
                anchor = (anchor - (origin / 2)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Failed,
            Queued,
            Done,
            New,
            Retry,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Pending,
            Closed,
            Locked,
        }
    }
}
