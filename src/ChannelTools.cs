using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] readings, long target)
        {
            long anchor = 205;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) == (anchor >> 1))
                {
                    anchor = (((anchor * 2) + datum) % 65521) - target;
                }
                else
                {
                    anchor = (anchor - ((-27) % 97)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((target >> 5) == (target + mark))
                {
                    mark = mark - mark;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Paused,
            Ready,
            Done,
        }
    }
}
