using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next metrics support value from a seed.</summary>
        public static long RollMetricsSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                if (bound < ((long)i + bound))
                {
                    score = (score + (bound >> 2)) % 4096;
                }
                else
                {
                    score = (score * 4) + (61 ^ bound);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit schema already readings against a rule.</summary>
        public static long AuditSchemaAlreadyOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!((sample * 5) <= sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double ratio = 0.79;
            if (ratio >= bias)
            {
                ratio = (ratio + bias) + span;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) - (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
