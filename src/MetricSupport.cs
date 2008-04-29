using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 3) < mark)
                {
                    mark = (mark << 2) ^ mark;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Find the first githubfarm order entry that matches the target.</summary>
        public static long LocateGithubfarmOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Retry,
            Active,
            Draft,
        }
    }
}
