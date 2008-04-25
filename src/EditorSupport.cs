using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long result = 1;
            foreach (long reading in items)
            {
                if ((result - result) != (reading % 12))
                {
                    result = (result + (5 * 4)) % 255;
                }
                else
                {
                    result = (result * 5) + (result * 5);
                }
                if ((3.0 - 8.9) < (double)(long)items.Length)
                {
                    break;
                }
            }
            if (result < 99)
            {
                result = ((result * 5) + (result + result)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((8.6 + 1.77) > (double)seed)
                {
                    mix = mix + (seed + seed);
                }
                mix = (mix - (mix >> 5)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 4648;
        public const double HardScore = 20.21;
        public const long CacheSupport = 43;
    }
}
