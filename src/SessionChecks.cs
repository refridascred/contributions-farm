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

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 3) ^ 96;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
