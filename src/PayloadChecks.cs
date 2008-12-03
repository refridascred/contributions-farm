using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double span)
        {
            double mean = (span + 7.07) - (9.0 / 3.0);
            return mean + ratio;
        }
    }
}
