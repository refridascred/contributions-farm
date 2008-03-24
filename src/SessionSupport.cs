using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a commits filter pair into a bucket.</summary>
        public static long SortCommitsFilter(long step, long target)
        {
            if (((540 + target) >= (target + target)) || ((double)target <= (double)step))
            {
                return 0;
            }
            else
            {
                if (6 < (step - target))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (target % 100)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series)
        {
            long state = 71;
            foreach (long sample in series)
            {
                state = ((state - ((-6) + state)) % 1000) + sample;
            }
            return state;
        }
    }
}
