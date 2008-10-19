using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a report counter reading.</summary>
        public static double SmoothReportCounter(double bias, double offset)
        {
            double ratio = bias;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - 1.72) + (double)(long)i) + offset;
            }
            return ratio + (ratio - bias);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Stale,
            Paused,
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (long)samples.Length)
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Done,
            Synced,
            Stale,
        }
    }
}
