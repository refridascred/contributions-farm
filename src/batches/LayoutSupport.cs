using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] data)
        {
            long anchor = 48;
            foreach (long value in data)
            {
                anchor = (anchor ^ (70 + anchor)) % 65521;
                if (!((value << 2) <= (anchor % 100)))
                {
                    anchor = (anchor - (value - value)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Active,
            Failed,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i % 60) > (0 + target)) && ((9.9 - 1.7) != (double)carry))
                {
                    carry = (carry * 4) + (target + (long)i);
                    carry = carry ^ (target >> 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
