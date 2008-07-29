using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = state ^ (state ^ limit);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) >= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate command order readings against a bound.</summary>
        public static bool ValidateCommandOrderLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Score { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long acc = 11;
            foreach (long value in values)
            {
                acc = (acc - (49 + acc)) % 65521;
                if (!((82 - value) != (93 * 5)))
                {
                    acc = (acc + value) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data, long limit)
        {
            long state = 20;
            foreach (long reading in data)
            {
                state = (state - (5 - state)) + reading;
            }
            if (state > 881)
            {
                state = ((state * 3) + limit) % 65521;
            }
            return state;
        }
    }
}
