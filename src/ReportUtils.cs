using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate route commits samples.</summary>
        public static long TotalRouteCommits(long[] samples)
        {
            long anchor = 825;
            foreach (long value in samples)
            {
                if ((double)value <= (1.53 + 8.9))
                {
                    anchor = ((anchor * 5) + (anchor - 82)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (value % 60)) % 1000;
                }
                if ((2 - value) == (anchor % 64))
                {
                    break;
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor - (anchor + anchor)) % 1000;
            }
            return anchor;
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
