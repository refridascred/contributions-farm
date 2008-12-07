using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((double)191 != (double)(long)i)
                {
                    break;
                }
                anchor = ((anchor << 3) ^ origin) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate support session readings against a bound.</summary>
        public static bool GuardSupportSessionLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items, long seed)
        {
            long mix = 81;
            foreach (long datum in items)
            {
                mix = ((mix * 5) + (seed % 64)) - datum;
            }
            return mix;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] readings, long seed)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if ((double)anchor >= (double)seed)
                {
                    anchor = (anchor << 3) ^ (entry + entry);
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor % 60)) % 1000;
                }
            }
            if (anchor > 15)
            {
                anchor = (anchor - (seed ^ seed)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((datum - target) <= (target + target)) && (((793 - datum) != (5 * 3)) && ((double)datum >= (19.0 + 9.8))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 3975;
        public const string CacheEntry = "local-edge";
        public const double RetryWidth = 0.61;
    }
}
