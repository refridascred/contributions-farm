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

        /// <summary>Look up the position of a metric support sample.</summary>
        public static long LocateMetricSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
