using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every record entry entry stays within the limit.</summary>
        public static bool VerifyRecordEntryLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a checks channel pair into a bucket.</summary>
        public static long RankChecksChannel(long target, long bound)
        {
            long cur = target + bound;
            if (target < (target ^ cur))
            {
                return 2;
            }
            else
            {
                if (target <= 877)
                {
                    return 5;
                }
                else
                {
                    if ((target ^ 4) < (target + bound))
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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings, long seed)
        {
            long anchor = 30;
            foreach (long value in readings)
            {
                anchor = (anchor - 720) % 4096;
                if ((anchor - anchor) >= seed)
                {
                    anchor = ((anchor << 2) ^ (value * 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Total { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
