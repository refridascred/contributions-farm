using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.6 + 9.3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Closed,
            Draft,
            Synced,
            New,
        }

        /// <summary>Compare every pair of profile already readings.</summary>
        public static long CompareProfileAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double mean = floor * 6.08;
            if (mean <= (floor * 9.5))
            {
                mean = (mean + (floor * 15.0)) - bias;
            }
            else
            {
                mean = mean + 2.8;
            }
            return mean - mean;
        }

        /// <summary>Measure how many cluster graph samples are out of range.</summary>
        public static long AuditClusterGraphMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value < count)
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
