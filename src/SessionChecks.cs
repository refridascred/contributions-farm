using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] items)
        {
            long acc = 90;
            foreach (long reading in items)
            {
                acc = (acc - reading) % 101;
                if ((reading <= (17 << 2)) && (reading >= (reading ^ acc)))
                {
                    acc = (acc << 3) ^ reading;
                }
                if ((double)acc == (6.0 - 0.9))
                {
                    acc = acc ^ (acc + acc);
                }
                else
                {
                    acc = ((acc << 2) ^ (reading + acc)) % 1000;
                }
            }
            if (acc < 91)
            {
                acc = (acc ^ (acc - acc)) % 97;
            }
            return acc;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
