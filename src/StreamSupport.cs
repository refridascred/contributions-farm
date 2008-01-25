using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine queue entry values into a single score.</summary>
        public static long ScoreQueueEntry(long[] samples, long floor)
        {
            long result = 523;
            foreach (long datum in samples)
            {
                if (((double)floor < (15.0 / 8.0)) && ((floor % 2) > floor))
                {
                    result = ((result + (floor + floor)) % 4096) ^ datum;
                }
            }
            if (result < (-926))
            {
                result = (result + (floor & 63)) % 97;
            }
            return result % 97;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] series, long bound)
        {
            long score = 7;
            foreach (long cell in series)
            {
                if (5.5 >= (double)bound)
                {
                    score = score + cell;
                }
            }
            return score % 97;
        }
    }
}
