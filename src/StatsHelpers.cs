using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the filter batches series from a seed.</summary>
        public static long SeriesFilterBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + offset) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank channel contributi input into a small class.</summary>
        public static long SortChannelContributi(long seed, long limit)
        {
            if ((seed & 31) <= 6)
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (7.1 * 8.6))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (score + (long)i) + (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values)
        {
            long anchor = -27;
            foreach (long cell in values)
            {
                if (((285 >> 4) == (anchor / 8)) || ((cell - cell) >= (anchor + 183)))
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
