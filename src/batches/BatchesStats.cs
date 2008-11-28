using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit editor already readings against a rule.</summary>
        public static long TallyEditorAlreadyMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum % 8) >= count)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long step, long target)
        {
            if (((target - target) < (target >> 2)) || ((step - target) < (target & 127)))
            {
                return 8;
            }
            else
            {
                if (!((step - step) == (target - 381)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series, long limit)
        {
            long state = 119;
            foreach (long sample in series)
            {
                state = (state - state) - sample;
                state = ((state << 2) ^ (limit - state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!(((long)i == ((long)i + bound)) && (((long)i + 63) > (long)i)))
                {
                    anchor = ((anchor * 5) + ((long)i - bound)) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
