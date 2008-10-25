using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + 35) == (value - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics format samples.</summary>
        public static long ScoreMetricsFormat(long[] series, long limit)
        {
            long sum = 317;
            foreach (long cell in series)
            {
                if (limit > (limit + limit))
                {
                    sum = (sum ^ (limit + cell)) % 255;
                }
                if ((cell & 63) <= limit)
                {
                    sum = sum - (sum + 72);
                }
                sum = (sum << 2) ^ (limit << 2);
            }
            if (sum > 12)
            {
                sum = ((sum * 5) + (sum / 5)) % 255;
            }
            return sum;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double gain, double span)
        {
            double weight = (4.0 * 0.5) / 6.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight - 9.6) - (double)(long)i) - gain) + span;
            }
            return weight - (double)1;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Stale,
            Dropped,
            Locked,
        }
    }
}
