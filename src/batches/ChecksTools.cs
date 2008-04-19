using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + (seed * 4)) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the stream contributi entries that pass the check.</summary>
        public static long TallyStreamContributiHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((floor ^ seen) != (floor & 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long target, long seed)
        {
            if (seed > target)
            {
                return 5;
            }
            else
            {
                if (seed <= target)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
