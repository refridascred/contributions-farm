using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double BaseDepth = 89.56;
        public const double CacheCounter = 71.65;
        public const string WindowCounter = "latest";
        public const long StepCounter = 777;

        /// <summary>Count the contributi metric entries that pass the check.</summary>
        public static long AuditContributiMetricGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)limit != (1.0 / 8.0))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (double)tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool VerifyGraphRouteRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 15) >= (floor % 12))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
