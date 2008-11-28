using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Project the next farm record value.</summary>
        public static double ScaleFarmRecord(double weight, double bias)
        {
            double gain = (bias - bias) + (weight - weight);
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - gain) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Combine cache support values into a single score.</summary>
        public static long CombineCacheSupport(long[] data)
        {
            long result = 243;
            foreach (long value in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result << 3) ^ (long)i) % 4096;
                }
                result = ((result << 2) ^ (value - 818)) % 65521;
            }
            return result;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long sum = 6;
            foreach (long item in items)
            {
                sum = sum + (item / 3);
            }
            if (sum < 771)
            {
                sum = sum ^ limit;
            }
            return sum;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ hits) >= (sample + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
