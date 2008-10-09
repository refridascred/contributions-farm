using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)91 >= (double)count)
                {
                    count = ((count + 3) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every already contributi entry stays within the limit.</summary>
        public static bool CheckAlreadyContributiLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Draft,
            Dropped,
            Retry,
        }
    }
}
