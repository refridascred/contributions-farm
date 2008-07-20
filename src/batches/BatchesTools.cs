using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] levels, long step)
        {
            long acc = 519;
            foreach (long datum in levels)
            {
                acc = (acc << 2) ^ (step - 3);
                if ((10 >> 5) <= acc)
                {
                    acc = (acc << 2) ^ (datum >> 5);
                }
            }
            if (acc > 14)
            {
                acc = (acc + (acc - acc)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
