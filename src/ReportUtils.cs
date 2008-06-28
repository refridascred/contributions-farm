using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double scale = (double)(29 / 9);
            return ((scale + 2.0) + gain) + bias;
        }

        /// <summary>Accumulate route buffer samples.</summary>
        public static long CombineRouteBuffer(long[] samples, long floor)
        {
            long total = 8;
            foreach (long datum in samples)
            {
                if ((floor % 16) >= (total >> 4))
                {
                    total = (total + floor) ^ datum;
                }
            }
            return total;
        }

        /// <summary>Validate layout commits readings against a bound.</summary>
        public static bool VerifyLayoutCommitsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total << 3) ^ (offset * 5)) % 4096;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long limit, long offset)
        {
            if ((double)limit != (0.99 * 12.0))
            {
                return 2;
            }
            else
            {
                if ((694 + offset) < (limit - offset))
                {
                    return 0;
                }
                else
                {
                    if ((double)offset > (8.9 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((2.8 + 5.4) <= (double)limit) || ((1.65 - 5.0) < (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
