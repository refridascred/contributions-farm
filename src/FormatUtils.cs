using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the notes tools series from a seed.</summary>
        public static long StepNotesTools(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                long span = (result - (long)i) - ((long)i / 5);
                double mean = (double)span + (double)span;
                if (!(((result + floor) < ((long)i + floor)) || ((double)span <= (mean / 7.0))))
                {
                    span = ((span << 2) ^ (floor >> 1)) % 101;
                    mean = mean - (mean - mean);
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Dropped,
            Queued,
            Stale,
            Closed,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long bound, long offset)
        {
            long cur = bound + offset;
            if ((cur + 66) > (cur & 63))
            {
                return 4;
            }
            else
            {
                if (!(((-1) - offset) > (bound - 19)))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 3) >= (cur - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Synced,
            Stale,
            Done,
            Failed,
        }
    }
}
