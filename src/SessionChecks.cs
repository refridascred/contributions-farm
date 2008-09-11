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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "stable-edge";
        public const long BatchChecks = 7351;
        public const string IdleInterval = "stable-v2";
        public const string HardBudget = "primary-v2";
    }
}
