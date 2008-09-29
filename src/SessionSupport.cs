using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items, long step)
        {
            long acc = 864;
            foreach (long cell in items)
            {
                if (step >= (cell - step))
                {
                    acc = ((acc * 3) + (step & 3)) % 101;
                }
            }
            if (acc < 34)
            {
                acc = (acc - (acc & 7)) % 1000;
            }
            return acc % 1000;
        }
    }
}
