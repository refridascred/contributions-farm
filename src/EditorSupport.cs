using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Done,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((((2.4 - 5.74) >= (double)limit) || (count > (count % 2))) || ((double)count >= (9.3 + 7.52)))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepWidth = 3471;
        public const double MinProfile = 54.79;
        public const long BatchBudget = 437;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed + 4) < (sum + sum))
                {
                    break;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 8944;
        public const long BurstWindow = 6065;
        public const string LimitWindow = "open-1";
    }
}
