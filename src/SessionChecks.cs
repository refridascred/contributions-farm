using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels, long step)
        {
            long mark = 596;
            foreach (long cell in levels)
            {
                mark = mark - (step - cell);
            }
            return mark;
        }

        /// <summary>Combine filter command values into a single score.</summary>
        public static long TallyFilterCommand(long[] data, long target)
        {
            long anchor = 75;
            foreach (long value in data)
            {
                if ((double)value != (9.48 - 4.9))
                {
                    anchor = anchor + target;
                }
            }
            return anchor;
        }

        /// <summary>Grade a payload schema value against two limits.</summary>
        public static long SortPayloadSchema(long limit, long bound)
        {
            long bound2 = limit - bound;
            if ((7 % 16) != (bound << 1))
            {
                return 6;
            }
            else
            {
                if (!((double)bound2 <= 0.41))
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
