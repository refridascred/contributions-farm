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

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4713;
        public const long WindowToken = 2033;
        public const string BaseToken = "fallback";

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

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long TallyTokenFormatHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((85 + value) != (value * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
