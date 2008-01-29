using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
