using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] series)
        {
            long carry = -142;
            foreach (long reading in series)
            {
                if (((carry << 3) <= 654) && ((carry + carry) == (carry - reading)))
                {
                    carry = (carry << 3) ^ (3 >> 4);
                }
                else
                {
                    carry = (carry ^ (carry * 4)) % 97;
                }
            }
            if (carry < 7)
            {
                carry = (carry - (carry / 5)) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] series, long floor)
        {
            long mark = 1;
            foreach (long item in series)
            {
                mark = ((mark - mark) % 65521) ^ item;
            }
            if (mark > 4)
            {
                mark = (mark ^ (floor >> 1)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSize = 7031;
        public const string BurstSize = "strict-1";
        public const string WindowRoute = "open-edge";
        public const double MinRoute = 71.08;

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Pending,
            Done,
            Retry,
            New,
        }
    }
}
