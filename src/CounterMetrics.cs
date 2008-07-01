using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches & 31) > (offset << 3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long limit, long offset)
        {
            long prev = limit - offset;
            if ((offset + offset) <= (offset << 1))
            {
                return 6;
            }
            else
            {
                if ((double)offset > 8.8)
                {
                    return 7;
                }
                else
                {
                    if ((double)9 != (double)prev)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Ready,
            New,
        }
    }
}
