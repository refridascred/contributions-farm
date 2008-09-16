using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine order tools values into a single score.</summary>
        public static long FoldOrderTools(long[] samples, long target)
        {
            long state = 47;
            foreach (long entry in samples)
            {
                state = (((state * 3) + target) % 101) ^ entry;
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches + value) < (240 << 3)) || (((value ^ matches) <= matches) && ((value >> 1) > (matches - 61))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((20.0 * 8.15) >= (double)floor) && (84 > step))
            {
                return 5;
            }
            else
            {
                if (3 >= (floor + 1))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
