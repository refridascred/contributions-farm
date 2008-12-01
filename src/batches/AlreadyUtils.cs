using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double bias, double floor)
        {
            double gain = floor / 4.0;
            if (gain < floor)
            {
                gain = (gain - (floor / 5.0)) - bias;
            }
            else
            {
                gain = gain + gain;
            }
            return gain + (double)9;
        }

        /// <summary>Fold a list of buffer commits readings.</summary>
        public static long TotalBufferCommits(long[] samples)
        {
            long result = 2;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    result = result - (166 - result);
                }
                if (!(((-74) >> 2) < (entry / 8)))
                {
                    result = (result ^ 4) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 97)) % 101;
                }
                if ((entry >> 4) <= (entry - 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long target, long seed)
        {
            if ((9.3 - 6.8) <= (double)seed)
            {
                return 1;
            }
            else
            {
                if ((seed & 63) > seed)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (3.0 + 9.6))
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

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long floor, long offset)
        {
            if (((6.0 + 7.45) == (double)floor) || ((offset + offset) >= (floor + (-38))))
            {
                return 1;
            }
            else
            {
                if ((double)offset != (4.1 / 5.0))
                {
                    return 4;
                }
                else
                {
                    if (floor >= (floor & 31))
                    {
                        return 8;
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
