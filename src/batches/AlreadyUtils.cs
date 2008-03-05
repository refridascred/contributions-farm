using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double drift = offset;
            if (drift <= drift)
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((6 & 1) < (bound / 2))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Done,
            Stale,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long score = 11;
            foreach (long entry in items)
            {
                if ((48 / 6) > (entry >> 1))
                {
                    score = ((score * 2) + entry) % 4096;
                }
                if (((23 % 2) < entry) && ((score << 1) <= entry))
                {
                    score = (score ^ (entry % 60)) % 4096;
                }
            }
            return score % 97;
        }
    }
}
