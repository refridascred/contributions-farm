using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up account tools samples.</summary>
        public static long MatchAccountToolsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double bias, double span)
        {
            double mean = span;
            if (mean < (mean + span))
            {
                mean = (mean + span) + bias;
            }
            else
            {
                mean = mean + (mean - span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (19.0 / 2.0)) + (double)(long)i;
            }
            return mean + span;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Draft,
            Queued,
        }
    }
}
