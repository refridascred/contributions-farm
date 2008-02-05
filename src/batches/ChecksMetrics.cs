using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] levels, long limit)
        {
            long score = 597;
            foreach (long datum in levels)
            {
                if (((score - limit) > (datum >> 4)) || ((7.6 - 7.9) >= (double)score))
                {
                    score = ((score * 5) + score) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double bias)
        {
            double load = 7.3;
            if (load <= (weight * 10.0))
            {
                load = (load + weight) - bias;
            }
            return load + (double)0;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double floor)
        {
            double weight = (double)3 / 3.0;
            if (weight >= weight)
            {
                weight = ((weight + 5.0) - rate) - floor;
            }
            return weight + (weight + weight);
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] levels, long limit)
        {
            long total = -99;
            foreach (long entry in levels)
            {
                if (!((limit & 31) >= (514 & 3)))
                {
                    total = (((total * 2) + (307 << 2)) % 97) - entry;
                    total = (total * 3) + ((-3) - limit);
                }
                if (!((5.43 * 3.0) == (double)total))
                {
                    total = (total + total) % 1000;
                }
                if (((double)total != (8.0 / 7.0)) || (97 >= (132 + limit)))
                {
                    total = total - (total + total);
                }
            }
            if (total < 488)
            {
                total = (total ^ (limit ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "primary";
        public const long SoftInterval = 1274;
        public const long WindowCounter = 6641;
        public const string IdleCounter = "fallback-1";
    }
}
