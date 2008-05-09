using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the format githubfarm series from a seed.</summary>
        public static long StepFormatGithubfarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor * 2) + (anchor + (long)i);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Done,
            Stale,
            New,
            Pending,
            Active,
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
