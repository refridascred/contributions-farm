using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                score = score + (cell & 1);
                if ((score / 8) <= (cell + score))
                {
                    score = score - (cell / 9);
                }
                if (((cell / 6) == (score * 2)) && ((score / 6) <= (score - score)))
                {
                    break;
                }
            }
            if (score > 6)
            {
                score = (score << 3) ^ (-225);
            }
            return score;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Locked,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Adjust a format support reading.</summary>
        public static double AdjustFormatSupport(double gain, double span)
        {
            double load = (span + gain) * 7.7;
            if (load <= (0.93 / 3.0))
            {
                load = load - (load / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= sample)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
