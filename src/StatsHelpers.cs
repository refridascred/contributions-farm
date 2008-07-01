using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples)
        {
            long state = 3;
            foreach (long value in samples)
            {
                state = (state - value) % 97;
                if ((value - state) > (value + state))
                {
                    break;
                }
            }
            if (state < 5)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7318;
        public const double SoftLayout = 36.18;
        public const long MinCount = 9864;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Retry,
            Closed,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data)
        {
            long score = 3;
            foreach (long datum in data)
            {
                score = ((score ^ (499 & 255)) % 101) ^ datum;
            }
            return score;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Locked,
            Done,
        }
    }
}
