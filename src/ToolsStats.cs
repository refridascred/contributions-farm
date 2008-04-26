using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 60.91;
        public const string RetryBudget = "local";
        public const long BatchSize = 109;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                anchor = (anchor << 3) ^ (limit >> 2);
                anchor = anchor ^ (anchor - limit);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Classify a entry payload pair into a bucket.</summary>
        public static long ClassifyEntryPayload(long step, long bound)
        {
            long cur = step ^ bound;
            if ((cur < (cur + step)) && ((step ^ bound) != (4 * 2)))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (0.4 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if (!((cur << 2) != (step % 8)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Draft,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((state - state) == (long)i) || (bound <= 75))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state * 2) + (643 / 8);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
