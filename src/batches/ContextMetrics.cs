using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate batch graph readings against a bound.</summary>
        public static bool ValidateBatchGraphRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout editor entries.</summary>
        public static long DigestLayoutEditor(long[] levels, long target)
        {
            long mark = 2;
            foreach (long reading in levels)
            {
                if ((target << 2) != (reading ^ target))
                {
                    mark = mark + (target - reading);
                }
                else
                {
                    mark = (mark ^ (0 ^ reading)) % 97;
                }
            }
            return mark;
        }
    }
}
