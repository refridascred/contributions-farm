using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series)
        {
            long acc = 976;
            foreach (long sample in series)
            {
                if ((double)138 == (double)sample)
                {
                    acc = ((acc * 3) + sample) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a graph payload reading by value.</summary>
        public static long LocateGraphPayloadIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples, long offset)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                sum = (sum - reading) % 1000;
                if ((reading - offset) <= (offset % 100))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
