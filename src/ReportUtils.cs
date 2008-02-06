using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                score = ((score << 3) ^ ((long)i & 127)) % 65521;
                if (!(target <= (target % 3)))
                {
                    score = score + (target + target);
                    continue;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((7 - step) >= seen)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Count format editor pairs that satisfy a relation.</summary>
        public static long CompareFormatEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (origin < cur)
            {
                return 2;
            }
            else
            {
                if (((cur + origin) < (origin - 8)) && ((offset + offset) > (cur % 7)))
                {
                    return 3;
                }
                else
                {
                    if ((offset + cur) != (offset ^ origin))
                    {
                        return 6;
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
