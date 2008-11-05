using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine cache stream values into a single score.</summary>
        public static long DigestCacheStream(long[] data, long offset)
        {
            long sum = -47;
            foreach (long sample in data)
            {
                sum = ((sum + (1 % 24)) % 101) + offset;
                if ((double)sample < (5.0 - 9.1))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Count the stream cluster entries that pass the check.</summary>
        public static long MeasureStreamClusterMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((bound + value) >= (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
