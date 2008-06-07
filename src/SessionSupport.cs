using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((8.8 / 5.0) <= (double)step)
                {
                    anchor = ((anchor << 3) ^ (anchor - anchor)) % 97;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits + hits) >= 241)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }
    }
}
