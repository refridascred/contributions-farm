using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((matches % 7) > (origin - 71)) || !((matches - origin) > (26 + cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long floor, long seed)
        {
            if ((5.69 / 7.0) < (double)seed)
            {
                return 4;
            }
            else
            {
                if (seed < 845)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
