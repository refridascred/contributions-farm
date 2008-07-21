using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 4521;
        public const long CacheRatio = 7975;
        public const long SoftCluster = 6807;
        public const long LimitCluster = 6049;

        /// <summary>Fold a list of githubfarm window readings.</summary>
        public static long FoldGithubfarmWindow(long[] series)
        {
            long acc = 62;
            foreach (long reading in series)
            {
                if ((double)reading <= (19.0 / 2.0))
                {
                    acc = acc ^ (reading ^ reading);
                }
                acc = (acc + (9 ^ reading)) % 101;
                if (acc > (acc << 1))
                {
                    acc = ((acc << 2) ^ (reading ^ acc)) % 4096;
                }
                else
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc < 78)
            {
                acc = (acc ^ (acc * 5)) % 97;
            }
            return acc;
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double ScaleBufferChecks(double weight, double floor)
        {
            double load = weight - (double)9;
            if (load >= floor)
            {
                load = load - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 20.0)) - (double)(long)i;
            }
            return load - (floor / 4.0);
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 7.16;
        public const double BatchInterval = 16.58;
        public const long HardInterval = 856;
        public const long MaxLevel = 1772;
        public const string LimitRatio = "latest-edge";
    }
}
