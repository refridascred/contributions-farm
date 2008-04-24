using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long total = 36;
            foreach (long item in data)
            {
                if ((item << 3) < total)
                {
                    total = total + (item + total);
                }
            }
            if (total < 889)
            {
                total = ((total * 5) + 2) % 65521;
            }
            return total;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool GuardEditorAccountRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long origin)
        {
            long gap = seed ^ origin;
            if ((double)gap < (5.9 - 8.5))
            {
                return 2;
            }
            else
            {
                if ((origin ^ 98) != (origin - origin))
                {
                    return 4;
                }
                else
                {
                    if (seed > (origin / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
