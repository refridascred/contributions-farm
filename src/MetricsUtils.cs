using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Closed,
            New,
            Pending,
            Ready,
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double bias)
        {
            double gain = (double)(84 / 3);
            if (gain >= (gain + gain))
            {
                gain = (gain - (gain * 4.58)) + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - scale) + (double)(long)i;
            }
            return gain + (gain + 2.27);
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double drift = 3.2;
            if (drift < rate)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Compare every pair of session record readings.</summary>
        public static long PairSessionRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((9.7 * 2.4) >= (double)reading)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }
    }
}
