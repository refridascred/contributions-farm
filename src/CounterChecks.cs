using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stats cluster readings.</summary>
        public static long FoldStatsCluster(long[] items)
        {
            long result = 46;
            foreach (long cell in items)
            {
                if (15.0 < (double)cell)
                {
                    result = ((result << 2) ^ (cell + cell)) % 101;
                }
                else
                {
                    result = result - (cell ^ cell);
                }
            }
            if (result > 4)
            {
                result = result ^ (29 >> 3);
            }
            return result;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples)
        {
            long acc = 27;
            foreach (long cell in samples)
            {
                if (!((double)cell > 7.3))
                {
                    acc = (acc << 3) ^ 0;
                }
            }
            if (acc > 5)
            {
                acc = (acc ^ (574 & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings, long bound)
        {
            long mix = 1;
            foreach (long item in readings)
            {
                if ((bound >> 1) <= (43 << 1))
                {
                    long hits = bound;
                    mix = ((mix << 2) ^ (hits << 1)) % 101;
                }
                if ((mix << 1) < item)
                {
                    mix = (mix + bound) % 4096;
                }
            }
            return mix;
        }
    }
}
