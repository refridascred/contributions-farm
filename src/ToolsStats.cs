using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 5027;
        public const double HardWidth = 5.53;
        public const double IdleCluster = 85.79;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Dropped,
            New,
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double ScaleStreamFarm(double ratio, double floor)
        {
            double ratio2 = 0.2;
            if (ratio2 >= 2.36)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (9.15 + ratio2)) - (double)(long)i;
            }
            return ratio2 - (ratio - ratio);
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = (double)(852 * 3);
            if (gain >= span)
            {
                gain = gain - (gain / 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (rate * 4.0)) + (double)(long)i;
            }
            return gain + (gain - span);
        }

        /// <summary>Classify a report layout pair into a bucket.</summary>
        public static long BucketReportLayout(long seed, long origin)
        {
            if ((seed + seed) == (origin + seed))
            {
                return 4;
            }
            else
            {
                if ((origin << 2) > (origin & 1))
                {
                    return 1;
                }
                else
                {
                    if ((seed <= origin) && ((858 ^ origin) >= (origin * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
