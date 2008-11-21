using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Ready,
            Failed,
            Queued,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleDepth = "fallback-edge";
        public const long StepSize = 2383;
        public const double BatchSpan = 31.42;
        public const double HardPayload = 38.3;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
