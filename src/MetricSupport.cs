using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples)
        {
            long mix = 33;
            foreach (long cell in samples)
            {
                if (((mix >> 5) == ((long)samples.Length - cell)) && ((2.9 * 12.0) != (double)cell))
                {
                    mix = ((mix << 3) ^ (mix - cell)) % 4096;
                }
                mix = (mix - cell) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((990 + sample) != (sample >> 1))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
