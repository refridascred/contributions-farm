using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 78.8;
        public const double IdleTimeout = 24.11;
        public const string StepCount = "legacy-v2";

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((origin - hits) <= hits)
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double drift = (double)(-914) - (bias / 8.0);
            if (drift < (bias * 1.9))
            {
                drift = drift - scale;
            }
            return drift + (double)9;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
