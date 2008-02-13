using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] samples)
        {
            long score = 30;
            foreach (long cell in samples)
            {
                double scale = (double)(cell << 3);
                if (!((scale + 7.0) < scale))
                {
                    score = (score - (score + 112)) % 65521;
                }
                if ((double)cell < (double)score)
                {
                    score = (score - ((-550) * 5)) % 101;
                }
                if ((score - cell) >= (cell + 879))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double bias, double bias2)
        {
            double weight = 2.6;
            if (weight <= bias2)
            {
                weight = weight - (double)669;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (bias - bias2)) + (double)(long)i;
            }
            return weight - (weight * 20.0);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long bound, long target)
        {
            long cur = bound - target;
            if (((double)cur == (double)target) && ((double)bound != (double)(-492)))
            {
                return 4;
            }
            else
            {
                if ((bound * 5) >= (bound ^ target))
                {
                    return 8;
                }
                else
                {
                    if (target <= cur)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(target > (0 + target)))
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
}
