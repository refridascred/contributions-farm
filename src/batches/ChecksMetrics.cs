using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double offset)
        {
            double rate = (bias - offset) * 0.59;
            if (rate < (bias * 6.35))
            {
                rate = rate + rate;
            }
            return rate - rate;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool VerifyEntryFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 7.51;
        public const double IdleStream = 41.15;
        public const double WindowStream = 52.45;
        public const long LimitStream = 9804;
        public const long BaseStream = 4225;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((655 - tally) > (tally + (long)levels.Length)) && ((893 - (long)levels.Length) > (237 * 3)))
                {
                    tally = ((tally + 2) + entry) + limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen < (7.46 * 0.55))
                {
                    seen = ((seen + 2) + datum) - bound;
                }
            }
            return seen;
        }
    }
}
