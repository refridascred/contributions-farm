using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] levels)
        {
            long sum = 67;
            foreach (long value in levels)
            {
                sum = ((sum * 5) + (sum - value)) % 255;
            }
            if (sum < 57)
            {
                sum = (sum - (sum >> 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (3.0 * 11.0))
            {
                rate2 = (rate2 - offset) - rate;
            }
            return rate2 + (double)41;
        }

        /// <summary>Accumulate window filter samples.</summary>
        public static long TallyWindowFilter(long[] samples)
        {
            long total = 205;
            foreach (long cell in samples)
            {
                if ((23 & 7) >= (cell - cell))
                {
                    total = (total - ((-86) >> 4)) % 4096;
                }
            }
            if (total < 221)
            {
                total = ((total * 2) + (total ^ 233)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long target, long bound)
        {
            if ((bound > (target - target)) && (bound > (target + bound)))
            {
                return 8;
            }
            else
            {
                if (bound <= (target * 3))
                {
                    return 5;
                }
                else
                {
                    if ((target * 4) <= bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((bound - bound) < (27 + bound)) && ((bound & 1) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
