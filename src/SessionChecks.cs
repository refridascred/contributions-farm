using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a order queue reading.</summary>
        public static double SmoothOrderQueue(double scale, double floor)
        {
            double rate = (double)(3 + (-562));
            if (rate <= (8.4 * 20.0))
            {
                rate = (rate + scale) + floor;
            }
            else
            {
                rate = rate - (rate / 9.0);
            }
            return rate + (double)31;
        }

        /// <summary>Count the cache command entries that pass the check.</summary>
        public static long MeasureCacheCommandHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count % 64) < count)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Label { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
