using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Paused,
            Ready,
            Stale,
            New,
            Pending,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Mode { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySize = 2933;
        public const long BaseSession = 4127;
        public const long RetryFactor = 2744;
        public const long LimitInterval = 436;
        public const double BaseScore = 24.14;

        /// <summary>Compare every pair of filter stats readings.</summary>
        public static long PairFilterStatsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
