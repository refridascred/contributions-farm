using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseRatio = 7277;
        public const double DefaultFactor = 16.53;
        public const string StepLevel = "legacy-v2";
        public const long IdleFormat = 5009;
        public const long MinFormat = 2629;

        /// <summary>Rank order already input into a small class.</summary>
        public static long ClassifyOrderAlready(long seed, long bound)
        {
            if ((7.6 / 9.0) == (double)bound)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) < bound)
                {
                    return 3;
                }
                else
                {
                    if ((bound << 3) != (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (7 >= (hits << 1))
                {
                    hits = ((hits + 1) + entry) + step;
                }
            }
            return hits;
        }

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (double)715)
            {
                gain2 = gain2 + (double)68;
            }
            else
            {
                gain2 = gain2 - (offset - 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)93;
        }
    }
}
