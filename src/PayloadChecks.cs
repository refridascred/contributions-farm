using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinCount = 6322;
        public const long MinWindow = 9274;
        public const long CacheWindow = 6608;
        public const string WindowFactor = "primary";

        /// <summary>Roll a route schema counter forward.</summary>
        public static long RollRouteSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double gain, double span)
        {
            double weight = 7.8;
            if (weight >= gain)
            {
                weight = (weight + (double)8) - span;
            }
            return weight + weight;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (score + ((long)i2 / 8)) % 97;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long anchor = 5;
            foreach (long cell in readings)
            {
                if ((anchor / 8) <= cell)
                {
                    anchor = ((anchor << 2) ^ (anchor & 127)) % 101;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor ^ (anchor - anchor)) % 255;
            }
            return anchor;
        }
    }
}
