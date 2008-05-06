using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next contributi already value from a seed.</summary>
        public static long RollContributiAlready(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(seed <= (long)i))
                {
                    acc = (acc - acc) % 4096;
                    acc = (acc << 2) ^ acc;
                }
                acc = ((acc * 4) + (86 + acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 53;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                if ((26 < cell) && ((double)carry > (4.1 / 8.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
