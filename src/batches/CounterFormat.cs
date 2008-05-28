using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Active,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if ((mix + 476) >= datum)
                {
                    mix = (mix * 5) + (datum ^ mix);
                }
                else
                {
                    mix = (mix - (mix + 32)) % 4096;
                }
            }
            return mix;
        }
    }
}
