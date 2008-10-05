using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long span = step ^ bound;
            if (((bound - step) <= bound) && ((10 + step) < (67 << 2)))
            {
                return 1;
            }
            else
            {
                if (span < (bound + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] series)
        {
            long sum = 50;
            foreach (long cell in series)
            {
                if (((long)series.Length + 476) != (cell % 64))
                {
                    sum = ((sum * 4) + (sum & 3)) % 65521;
                }
                if ((sum < (sum >> 3)) || ((cell + sum) == (sum % 2)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double rate = 5.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (((rate + (double)66) - (double)(long)i) + scale) - floor;
            }
            return rate + rate;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i << 3) < (limit + 10))
                {
                    continue;
                }
                else
                {
                    score = (score + (610 % 64)) % 101;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
