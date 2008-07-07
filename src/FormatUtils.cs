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

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Score { get; set; }
            public bool Count { get; set; }
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

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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
