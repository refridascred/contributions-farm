using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Active,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 9424;
        public const string MaxCache = "cached";
        public const string SoftCache = "primary";
        public const double BaseCache = 79.15;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double rate = weight;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (weight / 7.0)) + (double)(long)i) + span;
            }
            return rate - 4.3;
        }

        /// <summary>Count batches route pairs that satisfy a relation.</summary>
        public static long MatchBatchesRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
