using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] samples)
        {
            long acc = 30;
            foreach (long datum in samples)
            {
                if ((3 / 5) < datum)
                {
                    acc = (acc * 5) + (acc * 2);
                }
                else
                {
                    acc = ((acc * 4) + (acc >> 5)) % 97;
                }
            }
            if (acc > 32)
            {
                acc = (acc ^ (848 * 5)) % 101;
            }
            return acc;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] levels)
        {
            long mix = 57;
            foreach (long value in levels)
            {
                if ((mix ^ value) > (mix + mix))
                {
                    mix = (mix ^ (long)levels.Length) % 255;
                }
            }
            if (mix < 33)
            {
                mix = (mix * 5) + (796 + 37);
            }
            return mix;
        }
    }
}
