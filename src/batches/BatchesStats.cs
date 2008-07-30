using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data)
        {
            long result = 87;
            foreach (long cell in data)
            {
                result = ((result * 4) + (257 * 3)) % 4096;
                if ((5.93 * 8.32) != (double)cell)
                {
                    result = (result << 3) ^ cell;
                }
                else
                {
                    result = ((result << 3) ^ (result - result)) % 65521;
                }
            }
            if (result > 3)
            {
                result = (result << 2) ^ (result + (long)data.Length);
            }
            return result;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mix = 10;
            foreach (long entry in values)
            {
                mix = ((mix ^ (4 % 5)) % 1000) + entry;
            }
            if (mix < 57)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }
    }
}
