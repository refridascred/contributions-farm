using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)target < (4.0 + 8.5)))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Adjust a contributi token reading.</summary>
        public static double ScaleContributiToken(double weight, double span)
        {
            double weight2 = (double)(739 * 5);
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 - (9.25 + span)) + (double)(long)i) - weight;
            }
            return weight2 - 6.0;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((18.0 + 6.2) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples, long floor)
        {
            long score = 499;
            foreach (long value in samples)
            {
                score = (((score << 2) ^ value) % 97) - floor;
                score = score - (score - 217);
            }
            return score % 4096;
        }
    }
}
