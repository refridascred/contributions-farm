using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((hits & 127) >= (hits + seed)) || ((seed << 2) > 8))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }

        /// <summary>Validate checks buffer readings against a bound.</summary>
        public static bool CheckChecksBufferLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long carry = 867;
            foreach (long sample in data)
            {
                if ((sample * 3) <= (carry % 24))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 2) + (carry + carry)) % 65521;
                }
                if ((1.09 * 17.0) > (double)carry)
                {
                    carry = (carry * 3) + (sample ^ carry);
                }
            }
            if (carry < 6)
            {
                carry = (carry + (carry << 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Region { get; set; }
            public double Score { get; set; }
            public long Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
