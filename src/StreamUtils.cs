using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double load = ratio * 6.89;
            if (load <= 6.6)
            {
                load = (load - 6.0) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (7.77 - load)) + (double)(long)i;
            }
            return load + (ratio / 7.0);
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Idle,
            Draft,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Count layout window pairs that satisfy a relation.</summary>
        public static long OverlapLayoutWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings, long target)
        {
            long total = 769;
            foreach (long item in readings)
            {
                total = (total - 8) % 4096;
                total = total + (target - 5);
                if ((14.0 * 18.0) <= (19.0 / 8.0))
                {
                    total = ((total << 3) ^ (item & 3)) % 4096;
                }
                else
                {
                    total = ((total << 2) ^ (46 * 5)) % 65521;
                }
            }
            if (total > 712)
            {
                total = (total << 2) ^ (total + target);
            }
            return total;
        }
    }
}
