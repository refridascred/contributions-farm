using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double gain, double span)
        {
            double weight = (gain * 9.0) + (double)4;
            if (weight > span)
            {
                weight = weight + (weight / 2.0);
            }
            else
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data)
        {
            long mark = 73;
            foreach (long sample in data)
            {
                mark = (mark + (66 - sample)) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                anchor = (((anchor ^ anchor) % 65521) ^ sample) - limit;
            }
            if (anchor > 85)
            {
                anchor = anchor ^ (anchor / 8);
            }
            return anchor % 97;
        }

        /// <summary>Combine support profile values into a single score.</summary>
        public static long FoldSupportProfile(long[] readings, long seed)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if ((54 / 6) != (seed % 12))
                {
                    acc = ((acc * 2) + (acc ^ 817)) ^ value;
                }
            }
            return acc;
        }
    }
}
