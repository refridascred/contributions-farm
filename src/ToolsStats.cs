using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] samples, long step)
        {
            long carry = 629;
            foreach (long reading in samples)
            {
                if ((reading + reading) < step)
                {
                    carry = (carry + (777 << 3)) % 97;
                }
            }
            if (carry < 92)
            {
                carry = (carry - step) % 97;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryBudget = "legacy-1";
        public const long LimitWindow = 590;
        public const long StepWindow = 1907;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((long)i - (long)i) == ((long)i + seed))
                {
                    anchor = ((anchor * 4) + seed) % 97;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Stale,
            New,
            Idle,
        }
    }
}
