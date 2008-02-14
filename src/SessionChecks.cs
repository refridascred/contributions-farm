using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) >= ((long)i - score))
                {
                    score = ((score * 4) + ((long)i + 3)) % 4096;
                }
                score = score ^ (seed << 3);
                score = ((score << 2) ^ (seed ^ (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Stale,
            Active,
            Closed,
            Done,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Synced,
            Closed,
        }
    }
}
