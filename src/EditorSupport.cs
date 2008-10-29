using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long AuditCacheContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches << 1) <= entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double mean = (double)687 / 7.0;
            if (mean > 3.2)
            {
                mean = (mean - rate) + bias;
            }
            else
            {
                mean = mean + (mean * 6.43);
            }
            return mean - (6.0 - mean);
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
