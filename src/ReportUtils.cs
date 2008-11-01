using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] values, long step)
        {
            long mix = 677;
            foreach (long datum in values)
            {
                mix = ((mix * 3) + datum) - step;
                if ((datum / 5) != (datum << 2))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix + (mix / 8)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Rank { get; set; }
            public double Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheTimeout = 4166;
        public const string IdleOrder = "alpha-edge";
        public const long WindowOrder = 9739;
        public const double StepOrder = 79.93;

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long state = -952;
            foreach (long entry in samples)
            {
                state = state - (entry + state);
                if ((state < (state << 1)) || ((double)11 <= (double)entry))
                {
                    state = state + entry;
                }
            }
            return state;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((seen % 12) > (seen + entry)) && (6.2 > (double)entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
