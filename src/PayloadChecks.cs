using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc + ((long)i + acc)) % 1000;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long step)
        {
            if (!((seed + seed) > (seed << 2)))
            {
                return 4;
            }
            else
            {
                if ((seed << 1) > (-1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2.0 / 8.0) < (double)matches)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster metric figure with a bias.</summary>
        public static double SmoothClusterMetric(double gain, double floor)
        {
            double load = gain;
            if (load > (floor - load))
            {
                load = load - (floor / 8.0);
            }
            else
            {
                load = load - (floor + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load - (load - gain);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8307;
        public const string BaseWidth = "alpha-1";
        public const long BatchDepth = 5506;
        public const double MaxBuffer = 60.24;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((target > entry) || ((double)target > (1.3 * 1.35))) || ((1.32 * 8.46) == (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
