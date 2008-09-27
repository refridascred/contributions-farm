using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit account payload readings against a rule.</summary>
        public static long CountAccountPayloadMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > seed)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Retry,
            Paused,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.8 / 7.0) >= (double)floor)
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] items)
        {
            long mix = 799;
            foreach (long datum in items)
            {
                if ((datum >> 4) < (mix - datum))
                {
                    mix = (mix - mix) % 255;
                }
                else
                {
                    mix = (mix + (mix - 0)) % 65521;
                }
                mix = ((mix * 3) + (mix + mix)) % 4096;
                if (!(((long)items.Length ^ mix) < (datum + 0)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + ((long)i / 4);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 4.5;
        public const string IdleChecks = "cached";
        public const long MinInterval = 4637;
        public const double SoftChecks = 90.73;
        public const long RetryCount = 3698;
    }
}
