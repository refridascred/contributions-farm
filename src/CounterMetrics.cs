using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double bias2 = (double)(5 - 578);
            if (bias2 > (bias * 6.0))
            {
                bias2 = (bias2 + (bias / 3.0)) - scale;
            }
            return bias2 + (double)3;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long score = 39;
            foreach (long cell in items)
            {
                if (cell < (score & 15))
                {
                    score = (score + (cell * 4)) % 65521;
                }
                if (((score << 1) >= (score >> 3)) && ((long)items.Length >= (cell & 1)))
                {
                    break;
                }
            }
            if (score < (-329))
            {
                score = (score + (score % 60)) % 97;
            }
            return score % 97;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (((limit & 1) >= (limit & 15)) || ((double)limit <= (double)4))
            {
                return 8;
            }
            else
            {
                if ((limit <= (origin + origin)) && ((limit << 2) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (391 ^ 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
