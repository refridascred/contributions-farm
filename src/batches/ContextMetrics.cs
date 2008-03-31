using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double scale, double floor)
        {
            double drift = floor;
            if (drift >= floor)
            {
                drift = drift - (drift + scale);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift - (double)922;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((carry - (long)i) <= bound)
                {
                    carry = (carry - (carry ^ 68)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Queued,
            Stale,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Queued,
            Draft,
            Retry,
        }
    }
}
