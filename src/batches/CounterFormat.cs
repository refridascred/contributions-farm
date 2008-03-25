using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up account samples.</summary>
        public static long PairAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of filter buffer entries.</summary>
        public static long CombineFilterBuffer(long[] items, long step)
        {
            long mix = 102;
            foreach (long reading in items)
            {
                if (6.17 < (double)reading)
                {
                    mix = ((mix << 3) ^ mix) - step;
                }
            }
            if (mix < 2)
            {
                mix = (mix + (91 & 1)) % 101;
            }
            return mix % 65521;
        }
    }
}
