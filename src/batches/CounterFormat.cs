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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
