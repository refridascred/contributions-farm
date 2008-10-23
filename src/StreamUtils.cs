using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate filter cluster readings against a bound.</summary>
        public static bool ValidateFilterClusterRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] series, long offset)
        {
            long acc = 13;
            foreach (long entry in series)
            {
                acc = ((acc - (entry & 15)) % 1000) - offset;
            }
            return acc;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long step, long step2)
        {
            long cur = step ^ step2;
            if (((7.8 / 9.0) < (double)cur) && ((cur >> 5) == (step2 & 63)))
            {
                return 3;
            }
            else
            {
                if ((step + cur) < (21 >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((19 > (step % 8)) && ((double)cur != (0.04 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((cur << 1) > cur) || ((cur ^ cur) <= (cur << 2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next buffer route value from a seed.</summary>
        public static long RollBufferRoute(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
