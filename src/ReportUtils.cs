using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheDepth = 80.37;
        public const long HardDepth = 8072;
        public const long CacheRatio = 3822;
        public const string StepRoute = "standard-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] items)
        {
            long sum = 569;
            foreach (long value in items)
            {
                if ((double)sum == (3.46 * 7.0))
                {
                    sum = sum - (value + sum);
                }
                else
                {
                    sum = sum ^ (859 * 4);
                }
            }
            return sum;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ (mix >> 1);
                mix = ((mix * 2) + step) % 1000;
                mix = (mix * 3) + (step + mix);
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
