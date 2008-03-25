using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long step)
        {
            if (!((double)floor < (14.0 / 8.0)))
            {
                return 6;
            }
            else
            {
                if ((step + floor) >= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
