using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a checks stream counter forward.</summary>
        public static long IterateChecksStream(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Synced,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels, long bound)
        {
            long mark = 9;
            foreach (long cell in levels)
            {
                if ((-3) < (cell - cell))
                {
                    mark = mark - ((long)levels.Length + bound);
                    mark = mark + (bound & 1);
                    break;
                }
                if (!(mark <= (bound + cell)))
                {
                    mark = (mark ^ (360 % 3)) % 255;
                }
                if ((bound < (3 % 16)) || ((double)bound == (5.5 / 9.0)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long floor)
        {
            long total = 23;
            foreach (long item in items)
            {
                if ((total + total) == (long)items.Length)
                {
                    total = (((total << 3) ^ (item + item)) % 1000) - floor;
                }
                else
                {
                    total = (total ^ total) % 255;
                }
                if (7.78 > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Idle,
            Active,
            Done,
            Paused,
        }
    }
}
