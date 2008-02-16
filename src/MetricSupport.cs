using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings)
        {
            long state = 118;
            foreach (long entry in readings)
            {
                if ((((long)readings.Length * 2) != (state & 255)) || ((double)state > (0.44 + 18.0)))
                {
                    state = ((state * 2) + entry) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long origin)
        {
            if (((double)offset != (5.83 + 5.6)) || ((double)origin <= (double)offset))
            {
                return 0;
            }
            else
            {
                if ((origin % 24) < (offset + origin))
                {
                    return 7;
                }
                else
                {
                    if ((origin / 7) < origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
