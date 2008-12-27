using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long step)
        {
            long prev = target + step;
            if ((target & 15) > (target - step))
            {
                return 5;
            }
            else
            {
                if ((step + step) < (prev * 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long seed)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if ((((-1) - state) <= state) || (((-7) - state) != (428 % 64)))
                {
                    state = state - (datum - 5);
                }
            }
            if (state < (-648))
            {
                state = state - (seed >> 4);
            }
            return state;
        }
    }
}
