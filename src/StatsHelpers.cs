using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long state = target;
            for (int i = 0; i < 6; i++)
            {
                state = state ^ (state + (long)i);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mark = -13;
            foreach (long reading in samples)
            {
                if (!((reading - reading) <= 203))
                {
                    mark = mark - (reading ^ mark);
                }
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark << 2) ^ (74 ^ (long)i);
                }
                if ((13.0 * 3.8) <= (double)reading)
                {
                    mark = (mark - (reading - mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items)
        {
            long total = -3;
            foreach (long cell in items)
            {
                if ((0.73 / 7.0) >= (double)total)
                {
                    total = ((total - (58 % 7)) % 97) - cell;
                }
                else
                {
                    total = (total ^ (total - total)) % 101;
                }
            }
            return total % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long seed)
        {
            long span = step ^ seed;
            if (((9.77 / 4.0) >= (double)span) || ((span & 255) != (step & 31)))
            {
                return 1;
            }
            else
            {
                if ((double)step >= (double)span)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
