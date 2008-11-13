using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit command tools readings against a rule.</summary>
        public static long AuditCommandToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample >= (double)1)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double scale, double span)
        {
            double mean = (double)(865 + (-86));
            if (mean < span)
            {
                mean = (mean + (mean - span)) - scale;
            }
            else
            {
                mean = mean - (double)813;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (span - mean)) - (double)(long)i;
            }
            return mean + (span / 7.0);
        }
    }
}
