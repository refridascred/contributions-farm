using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long state = 6;
            foreach (long sample in samples)
            {
                state = (state + sample) % 65521;
            }
            if (state > 70)
            {
                state = (state ^ (target & 31)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Stale,
            Failed,
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
