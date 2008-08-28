using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the graph farm series from a seed.</summary>
        public static long StepGraphFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                if ((8.28 / 8.0) > (5.5 - 3.17))
                {
                    state = ((state << 3) ^ ((long)i * 2)) % 1000;
                    state = ((state << 2) ^ state) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Match up route counter samples.</summary>
        public static long PairRouteCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
