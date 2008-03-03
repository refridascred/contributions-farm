using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data, long origin)
        {
            long total = 9;
            foreach (long item in data)
            {
                total = (((total - total) % 101) + item) + origin;
                total = (total + (total << 1)) % 97;
                if ((total >> 4) == (2 & 63))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route context readings.</summary>
        public static long MatchRouteContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
