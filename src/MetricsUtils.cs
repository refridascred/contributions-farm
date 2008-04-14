using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 95.39;
        public const string DefaultCluster = "open-v2";
        public const long BurstCluster = 4692;
        public const long WindowWidth = 6255;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((long)series.Length + (long)series.Length) == (item % 10)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a stream token reading by value.</summary>
        public static long FindStreamTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] levels, long seed)
        {
            long anchor = 303;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor - anchor) % 1000) ^ (long)i) + reading;
                }
                if ((double)seed <= (4.92 - 7.0))
                {
                    anchor = (anchor ^ (anchor - anchor)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
