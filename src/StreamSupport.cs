using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Closed,
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long limit)
        {
            if (!(limit > (limit ^ 796)))
            {
                return 3;
            }
            else
            {
                if (((limit ^ limit) < 5) || ((70 + limit) < (361 & 255)))
                {
                    return 5;
                }
                else
                {
                    if ((5.53 - 18.0) != (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
