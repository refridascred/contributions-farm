using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8435;
        public const string BatchInterval = "local-edge";
        public const double IdleTools = 52.83;

        /// <summary>Combine profile command values into a single score.</summary>
        public static long TallyProfileCommand(long[] series, long target)
        {
            long carry = 483;
            foreach (long entry in series)
            {
                if (target > 519)
                {
                    carry = (carry - carry) % 255;
                    carry = (carry * 3) + (target - (-989));
                }
                if ((882 + entry) < entry)
                {
                    carry = (carry ^ (target ^ entry)) % 4096;
                }
                if ((carry - carry) <= (entry << 3))
                {
                    break;
                }
            }
            if (carry < 95)
            {
                carry = carry ^ (carry % 60);
            }
            return carry;
        }

        /// <summary>Compare every pair of cluster record readings.</summary>
        public static long OverlapClusterRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
