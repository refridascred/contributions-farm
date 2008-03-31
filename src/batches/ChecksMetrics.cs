using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long seed2)
        {
            if ((55 + seed) > seed)
            {
                return 5;
            }
            else
            {
                if (!((seed2 * 3) <= seed))
                {
                    return 3;
                }
                else
                {
                    if ((seed << 3) >= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) != (seed2 & 127))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((14.0 + 0.6) < (double)datum) || (datum >= (seen / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
