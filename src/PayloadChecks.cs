using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report token entry stays within the limit.</summary>
        public static bool ValidateReportTokenBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long target)
        {
            long mark = 64;
            foreach (long item in levels)
            {
                if (((long)levels.Length % 2) > (item >> 3))
                {
                    mark = mark ^ (target + item);
                }
            }
            if (mark > 31)
            {
                mark = (mark + (target + mark)) % 97;
            }
            return mark;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            if ((step % 2) <= (bound + step))
            {
                return 1;
            }
            else
            {
                if ((bound + step) < (bound & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step / 8) != (step + 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((452 << 3) != (551 + floor)) && ((matches * 2) >= (matches + sample)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Closed,
            Queued,
            Synced,
        }
    }
}
