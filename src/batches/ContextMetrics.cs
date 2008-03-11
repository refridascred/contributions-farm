using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long step)
        {
            if (((double)step <= 6.0) && (bound < step))
            {
                return 5;
            }
            else
            {
                if (((step & 15) > (step & 127)) || ((bound & 7) > (step - 326)))
                {
                    return 1;
                }
                else
                {
                    if (((-4) / 8) > (step >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long mark = 98;
            foreach (long entry in series)
            {
                if (mark >= (mark % 16))
                {
                    mark = (mark - (entry % 16)) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark * 4);
            }
            return mark % 1000;
        }
    }
}
