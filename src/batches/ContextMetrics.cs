using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Roll a account route counter forward.</summary>
        public static long SeriesAccountRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long anchor = 93;
            foreach (long item in items)
            {
                if ((8.0 + 9.24) <= (double)item)
                {
                    anchor = (anchor - (902 + anchor)) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long bound)
        {
            long span = step ^ bound;
            if ((double)span <= (double)span)
            {
                return 2;
            }
            else
            {
                if ((bound - step) >= (step + span))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every already route entry stays within the limit.</summary>
        public static bool ValidateAlreadyRouteLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
