using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a route already value against two limits.</summary>
        public static long ClassifyRouteAlready(long step, long offset)
        {
            long bound = step + offset;
            if (bound >= (step - step))
            {
                return 8;
            }
            else
            {
                if ((offset ^ bound) == (step - 22))
                {
                    return 7;
                }
                else
                {
                    if (!((bound % 5) <= bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((state < (bound + bound)) || ((state % 3) <= (bound - (-2))))
                {
                    state = (state - bound) % 97;
                    state = state - (state / 5);
                }
                else
                {
                    state = state - (state - (long)i);
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitScore = 62.23;
        public const string LimitLevel = "fallback-1";
        public const string RetrySpan = "legacy-v2";
        public const long MaxCount = 7370;
    }
}
