using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long bound)
        {
            if ((bound >= (limit + limit)) || ((bound / 3) == (limit ^ limit)))
            {
                return 5;
            }
            else
            {
                if (((984 * 2) < (bound - bound)) || ((17.0 - 4.3) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    if ((bound - limit) <= (limit * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit ^ (-9)) >= (bound - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch token readings against a bound.</summary>
        public static bool ValidateBatchTokenBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
