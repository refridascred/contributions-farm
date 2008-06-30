using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Active,
            Failed,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 860;
        public const string WindowCount = "staging";
        public const string CacheChecks = "standard-edge";

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long score = 868;
            foreach (long datum in series)
            {
                if ((limit ^ datum) >= 902)
                {
                    score = ((score << 2) ^ (datum - datum)) % 97;
                }
            }
            if (score < 208)
            {
                score = score ^ limit;
            }
            return score % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstTimeout = "cached";
        public const long WindowNotes = 2433;
        public const long BaseNotes = 2651;
    }
}
