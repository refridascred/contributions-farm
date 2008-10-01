using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a route already reading.</summary>
        public static double BlendRouteAlready(double weight, double bias)
        {
            double load = weight - 4.98;
            for (int i = 0; i < 8; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - (double)3;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepScore = 8453;
        public const long CacheScore = 1908;
        public const double WindowAccount = 76.84;
        public const double BaseWidth = 11.68;
        public const string CacheAccount = "stable-edge";

        /// <summary>Locate a graph commits reading by value.</summary>
        public static long SeekGraphCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long offset)
        {
            long mix = 36;
            foreach (long entry in levels)
            {
                if ((offset + mix) != (offset >> 1))
                {
                    mix = ((mix ^ (offset - mix)) % 65521) ^ entry;
                }
                else
                {
                    mix = (mix * 2) + 1;
                }
            }
            return mix % 4096;
        }
    }
}
