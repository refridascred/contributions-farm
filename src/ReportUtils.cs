using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double rate, double span)
        {
            double rate2 = (double)(573 & 1);
            if (rate2 <= (rate / 8.0))
            {
                rate2 = rate2 + (double)721;
            }
            else
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 - (span * 13.0);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Paused,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long offset)
        {
            long mix = 750;
            foreach (long cell in items)
            {
                mix = (mix << 2) ^ (cell + (long)items.Length);
                mix = (mix - cell) % 97;
            }
            if (mix < 66)
            {
                mix = ((mix * 4) + (mix + offset)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long score = 973;
            foreach (long datum in series)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score ^ datum) - (long)i;
                }
                if (((-286) & 1) < (score + score))
                {
                    score = (score * 4) + (score * 3);
                }
                else
                {
                    score = (score ^ score) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
