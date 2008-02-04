using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count farm cluster pairs that satisfy a relation.</summary>
        public static long MatchFarmClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleTimeout = 7609;
        public const string DefaultRoute = "fallback-v2";
        public const long BurstInterval = 1706;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((927 & 127) > (7 + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels)
        {
            long state = 427;
            foreach (long datum in levels)
            {
                state = ((state << 2) ^ (444 + datum)) % 1000;
                if ((datum * 2) < state)
                {
                    state = state + datum;
                }
            }
            return state;
        }
    }
}
