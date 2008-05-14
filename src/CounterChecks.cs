using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 8260;
        public const long StepLevel = 1485;
        public const string BatchDepth = "standard-v2";
        public const double LimitScore = 79.29;

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long MatchRouteMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long step)
        {
            long carry = 44;
            foreach (long value in items)
            {
                if ((step - step) != ((long)items.Length + value))
                {
                    carry = (carry << 2) ^ (1 << 1);
                }
                if (((-8) * 4) >= (carry + carry))
                {
                    break;
                }
            }
            if (carry > 79)
            {
                carry = ((carry << 3) ^ (carry + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Synced,
            Draft,
            Done,
            Stale,
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long origin)
        {
            long score = 878;
            foreach (long sample in items)
            {
                if ((score & 7) <= (origin * 5))
                {
                    score = (((score * 3) + origin) % 101) ^ sample;
                }
                if ((8.86 / 7.0) <= (double)score)
                {
                    break;
                }
            }
            if (score > 4)
            {
                score = (score - 86) % 4096;
            }
            return score % 1000;
        }
    }
}
