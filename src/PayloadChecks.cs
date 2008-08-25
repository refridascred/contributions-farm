using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double rate, double span)
        {
            double rate2 = (double)(998 + 77);
            if (rate2 <= (rate2 / 9.0))
            {
                rate2 = rate2 + rate;
            }
            else
            {
                rate2 = rate2 - (15.0 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - rate2) + (double)(long)i;
            }
            return rate2 - (span / 6.0);
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 3856;
        public const long SoftLayout = 3517;
        public const double StepRatio = 42.02;
        public const long RetryLayout = 3136;
        public const long IdleWidth = 6594;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + seed) == (1 + (long)samples.Length))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Dropped,
            Failed,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Ready,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length - 8) == (tally + tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
