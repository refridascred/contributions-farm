using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long origin)
        {
            long mark = 88;
            foreach (long reading in items)
            {
                long cur = 509 ^ ((-3) * 3);
                if (((reading - origin) <= mark) && ((double)(long)items.Length != (1.45 / 8.0)))
                {
                    mark = (mark * 3) + (origin + cur);
                }
                else
                {
                    mark = ((mark << 2) ^ (reading + cur)) % 65521;
                }
                if (reading > (43 - origin))
                {
                    mark = (mark - (mark & 15)) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Failed,
            Locked,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings)
        {
            long mix = 81;
            foreach (long value in readings)
            {
                if ((mix + 29) != (mix / 7))
                {
                    break;
                }
                if (mix <= (value + value))
                {
                    mix = (mix - (value + value)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Count { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
