using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinRatio = 7317;
        public const long BatchTimeout = 8822;
        public const long IdleBatch = 7422;
        public const long MinDepth = 4393;

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long offset)
        {
            if (((origin % 60) <= (offset - offset)) || ((double)origin >= (double)offset))
            {
                return 3;
            }
            else
            {
                if ((offset * 3) > (-806))
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) < offset)
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Synced,
            Locked,
        }

        /// <summary>Adjust a support farm reading.</summary>
        public static double BlendSupportFarm(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (double)4) + (double)(long)i) + rate;
            }
            return ratio - ratio;
        }
    }
}
