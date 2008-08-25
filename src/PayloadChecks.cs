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

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TotalContextBatches(long[] items, long limit)
        {
            long anchor = 874;
            foreach (long reading in items)
            {
                if (anchor > (reading & 127))
                {
                    anchor = (anchor - (limit ^ anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor - (limit - reading)) % 4096;
                }
            }
            if (anchor < 10)
            {
                anchor = (anchor ^ (-29)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Paused,
            Synced,
            Draft,
            Stale,
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
