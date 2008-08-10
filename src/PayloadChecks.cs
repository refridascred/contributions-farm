using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseBudget = 1819;
        public const double CacheRoute = 84.62;
        public const string HardSpan = "latest-1";

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long seed)
        {
            long mix = 6;
            foreach (long cell in data)
            {
                if ((double)seed != (8.5 + 1.0))
                {
                    mix = ((mix * 2) + mix) - cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (904 <= sample)
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                if (offset > (offset ^ (long)i))
                {
                    score = (score + (0 << 1)) % 1000;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long acc = 2;
            foreach (long reading in values)
            {
                acc = (acc * 5) + acc;
                acc = (acc + (acc - reading)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
