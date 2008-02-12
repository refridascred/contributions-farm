using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                long lane = (score ^ step) * 5;
                if ((lane >= (lane * 3)) || ((9.16 * 16.0) < (4.0 * 7.7)))
                {
                    score = (score << 2) ^ (lane ^ lane);
                    score = score - (long)i;
                }
                else
                {
                    score = ((score * 3) + ((long)i % 3)) % 255;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels, long offset)
        {
            long acc = 226;
            foreach (long item in levels)
            {
                if ((double)offset >= (double)764)
                {
                    acc = (((acc << 3) ^ (12 % 2)) % 65521) + item;
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up counter tools samples.</summary>
        public static long MatchCounterToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long mix = 675;
            foreach (long cell in values)
            {
                mix = (mix + (mix >> 1)) ^ cell;
            }
            return mix % 65521;
        }
    }
}
