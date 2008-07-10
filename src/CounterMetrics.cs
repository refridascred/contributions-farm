using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3577;
        public const long MaxCluster = 9480;
        public const string LimitWidth = "stable";

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((5.34 / 6.0) <= (double)sample)
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((value << 2) <= value) || (((long)series.Length < value) || (seen < 689)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
