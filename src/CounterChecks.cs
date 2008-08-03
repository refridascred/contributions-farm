using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "legacy-edge";
        public const double WindowDepth = 45.24;
        public const double BatchRatio = 95.93;
        public const string StepRatio = "alpha-1";
        public const long HardInterval = 6095;

        /// <summary>Blend two cluster session measurements.</summary>
        public static double AdjustClusterSession(double weight, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean + weight;
            }
            return mean - (weight * 9.77);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((4.2 - 9.9) != (double)step)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long offset)
        {
            long result = 272;
            foreach (long datum in levels)
            {
                result = (result + offset) % 1000;
                result = (result ^ datum) % 65521;
            }
            return result;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series, long bound)
        {
            long anchor = 52;
            foreach (long datum in series)
            {
                if (((anchor / 4) >= datum) && ((double)bound >= (double)7))
                {
                    anchor = (anchor * 5) + 928;
                }
                else
                {
                    anchor = (anchor + (datum + anchor)) % 1000;
                }
            }
            return anchor;
        }
    }
}
