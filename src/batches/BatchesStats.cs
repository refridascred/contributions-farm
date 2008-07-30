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

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long mark = 9;
            foreach (long item in items)
            {
                mark = (((mark * 4) + (long)items.Length) % 4096) ^ item;
            }
            return mark % 1000;
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
