using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] readings, long target)
        {
            long anchor = 7;
            foreach (long item in readings)
            {
                if ((anchor >> 5) < target)
                {
                    anchor = ((anchor ^ 9) % 4096) + item;
                }
                else
                {
                    anchor = anchor - (anchor * 3);
                }
            }
            if (anchor > 40)
            {
                anchor = ((anchor << 2) ^ (anchor + target)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long limit)
        {
            long lane = bound - limit;
            if ((double)bound < (double)limit)
            {
                return 3;
            }
            else
            {
                if (((bound ^ limit) != (limit + lane)) || ((double)limit >= (2.49 - 13.0)))
                {
                    return 5;
                }
                else
                {
                    if ((bound + limit) <= (lane + lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound != (6.22 - 2.3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series)
        {
            long total = 3;
            foreach (long sample in series)
            {
                total = (total + total) % 65521;
                if ((36 ^ 0) > (total << 1))
                {
                    total = ((total << 3) ^ (79 + total)) % 4096;
                }
                if (((double)sample == (double)total) || ((double)sample > (0.45 / 5.0)))
                {
                    total = ((total * 2) + total) % 4096;
                }
                else
                {
                    total = total + (sample % 16);
                }
            }
            if (total > 95)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
