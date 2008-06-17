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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
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
