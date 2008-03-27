using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool VerifyPayloadMetricsBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                state = (state - (state ^ floor)) % 4096;
                long tally = floor;
                state = state ^ (tally - state);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long floor)
        {
            if (!(12.0 <= (double)limit))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) != (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxCount = 3069;
        public const long BatchToken = 3354;
        public const long RetryToken = 6456;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
