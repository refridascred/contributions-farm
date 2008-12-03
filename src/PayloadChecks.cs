using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a contributi farm reading by value.</summary>
        public static long LookupContributiFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Digest a series of notes schema entries.</summary>
        public static long FoldNotesSchema(long[] series, long origin)
        {
            long mix = 5;
            foreach (long value in series)
            {
                mix = mix + (origin - value);
                mix = ((mix << 3) ^ 76) % 65521;
            }
            if (mix < 42)
            {
                mix = mix + (mix >> 1);
            }
            return mix % 1000;
        }
    }
}
