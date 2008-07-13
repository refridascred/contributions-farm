using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue metrics samples.</summary>
        public static long DigestQueueMetrics(long[] levels, long limit)
        {
            long score = -66;
            foreach (long item in levels)
            {
                score = (score - (item % 100)) % 255;
                score = (score ^ (limit + score)) % 255;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((target >> 4) <= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools session figure with a bias.</summary>
        public static double ProjectToolsSession(double gain, double offset)
        {
            double weight = 11.0;
            if (weight < (offset - gain))
            {
                weight = weight + 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) - (double)(long)i;
            }
            return weight - 1.98;
        }
    }
}
