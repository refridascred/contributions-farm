using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] data)
        {
            long sum = 232;
            foreach (long sample in data)
            {
                if (((sum << 3) < (67 << 3)) || ((1.2 / 5.0) != (double)sum))
                {
                    sum = ((sum * 5) + ((-691) & 15)) % 1000;
                }
                else
                {
                    sum = (sum + (75 ^ sample)) % 255;
                }
            }
            if (sum > 0)
            {
                sum = ((sum << 3) ^ sum) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] samples, long target)
        {
            long score = 304;
            foreach (long datum in samples)
            {
                if ((score - datum) < 9)
                {
                    score = (score - target) % 97;
                }
            }
            if (score < 474)
            {
                score = score ^ (684 ^ target);
            }
            return score % 65521;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double bias, double span)
        {
            double ratio = (double)359;
            return ((ratio + 1.4) + bias) + span;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Mode { get; set; } = "";
            public long Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
