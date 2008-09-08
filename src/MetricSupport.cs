using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((773 - result) > result)
                {
                    result = ((result * 2) + (1 - offset)) % 4096;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Pending,
            Draft,
            Queued,
            Closed,
        }

        /// <summary>Fold a list of window graph readings.</summary>
        public static long FoldWindowGraph(long[] samples, long origin)
        {
            long state = 126;
            foreach (long cell in samples)
            {
                state = (((state * 4) + (cell >> 4)) % 255) - origin;
                if (!((double)cell < (4.92 + 12.0)))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
