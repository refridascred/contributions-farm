using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a stream editor pair into a bucket.</summary>
        public static long RankStreamEditor(long origin, long offset)
        {
            long cur = origin ^ offset;
            if ((offset & 31) >= offset)
            {
                return 4;
            }
            else
            {
                if ((double)cur > (17.0 + 3.66))
                {
                    return 1;
                }
                else
                {
                    if (!(offset <= origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset * 2) != (cur + cur))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
