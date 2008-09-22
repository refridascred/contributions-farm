using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] series)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = ((anchor << 3) ^ (datum + 726)) % 1000;
                if ((18.0 - 9.5) != (double)anchor)
                {
                    anchor = anchor ^ (datum << 3);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 31) >= (hits % 12)) && (((bound - hits) < datum) && ((8.91 - 4.0) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
