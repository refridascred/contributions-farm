using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long floor)
        {
            if ((floor % 7) < bound)
            {
                return 4;
            }
            else
            {
                if (!(bound > ((-19) - floor)))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound ^ 205) > (floor * 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Draft,
            Retry,
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Iterate the editor payload series from a seed.</summary>
        public static long DeriveEditorPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (sum - floor)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen < 323) && ((double)sample < (0.7 - 3.0)))
                {
                    seen = (seen + 3) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
