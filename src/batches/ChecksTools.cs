using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit session farm readings against a rule.</summary>
        public static long TallySessionFarmHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry - count) < ((long)values.Length / 5)) && ((9.0 * 4.7) >= (double)count)) && (entry > (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long floor, long target)
        {
            long lane = floor ^ target;
            if (!(lane >= floor))
            {
                return 7;
            }
            else
            {
                if (!((target - floor) <= (target + target)))
                {
                    return 2;
                }
                else
                {
                    if ((double)4 != (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(413 < (target + lane)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric farm samples.</summary>
        public static long WeighMetricFarm(long[] levels, long origin)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                if ((cell >> 4) <= (acc + 7))
                {
                    acc = (acc + (origin & 63)) % 101;
                }
            }
            if (acc < 0)
            {
                acc = (acc - (836 * 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double offset)
        {
            double rate = offset;
            if (rate > 2.23)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + (rate - bias);
            }
            return rate - (offset / 7.0);
        }
    }
}
