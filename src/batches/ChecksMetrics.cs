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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long target, long step)
        {
            long delta = target - step;
            if (target <= (target + target))
            {
                return 7;
            }
            else
            {
                if ((double)delta != (double)9)
                {
                    return 4;
                }
                else
                {
                    if (delta <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] series)
        {
            long total = 32;
            foreach (long datum in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total * 3) + ((long)i - datum)) % 97;
                }
                if ((8.0 - 16.0) == (double)datum)
                {
                    total = ((total << 3) ^ (total + datum)) % 1000;
                }
            }
            return total;
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
