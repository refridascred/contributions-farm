using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Done,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell % 3) >= (380 + cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long bound)
        {
            if ((bound >> 3) != (bound * 5))
            {
                return 7;
            }
            else
            {
                if (bound >= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if ((5 + bound) <= 664)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next account context value from a seed.</summary>
        public static long RollAccountContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = ((mix ^ (0 + mix)) % 97) + (long)i2;
                }
                mix = ((mix << 3) ^ (103 & 1)) % 255;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
