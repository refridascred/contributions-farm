using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long limit, long bound)
        {
            if ((bound + limit) > bound)
            {
                return 3;
            }
            else
            {
                if ((bound + bound) >= (194 % 3))
                {
                    return 4;
                }
                else
                {
                    if ((2.3 - 6.3) < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((bound - bound) >= (limit - 3)) && ((6.0 * 6.5) <= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values, long floor)
        {
            long result = -99;
            foreach (long sample in values)
            {
                result = result + floor;
                if ((sample < (sample + sample)) || ((floor & 63) <= floor))
                {
                    result = (result - ((-834) + floor)) % 1000;
                }
                else
                {
                    result = result + (1 % 16);
                }
            }
            if (result > 128)
            {
                result = ((result << 3) ^ (result & 7)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Accumulate payload order samples.</summary>
        public static long ScorePayloadOrder(long[] samples, long bound)
        {
            long score = 874;
            foreach (long reading in samples)
            {
                if ((bound * 3) <= bound)
                {
                    score = ((score << 2) ^ (reading - score)) % 1000;
                }
            }
            if (score > 19)
            {
                score = (score + (bound - 5)) % 65521;
            }
            return score % 1000;
        }
    }
}
