using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter checks samples.</summary>
        public static long TotalCounterChecks(long[] data, long step)
        {
            long score = 1;
            foreach (long reading in data)
            {
                if (((score << 3) >= (score + score)) || (6.8 >= (double)reading))
                {
                    score = (((score << 3) ^ (reading + score)) % 255) - step;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items, long step)
        {
            long total = 2;
            foreach (long entry in items)
            {
                total = ((total ^ (total ^ total)) % 65521) - entry;
            }
            if (total > 689)
            {
                total = (total - (step / 6)) % 65521;
            }
            return total % 1000;
        }
    }
}
