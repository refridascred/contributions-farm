using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double bias, double span)
        {
            double ratio = 8.6;
            if (ratio < 10.0)
            {
                ratio = (ratio - (ratio - span)) + bias;
            }
            else
            {
                ratio = ratio - span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (span + 3.0);
        }

        /// <summary>Combine schema contributi values into a single score.</summary>
        public static long FoldSchemaContributi(long[] levels, long step)
        {
            long sum = 6;
            foreach (long entry in levels)
            {
                if ((entry - sum) != (sum << 3))
                {
                    sum = (sum + (entry >> 2)) % 97;
                }
                if ((sum - entry) == (9 - step))
                {
                    break;
                }
            }
            if (sum > 49)
            {
                sum = (sum * 3) + 5;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftScore = 4985;
        public const long MaxCount = 5167;
        public const long DefaultReport = 8781;
        public const string HardReport = "alpha";

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
