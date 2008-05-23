using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples)
        {
            long mix = 4;
            foreach (long datum in samples)
            {
                mix = ((mix << 3) ^ (datum >> 2)) % 255;
                if (((long)samples.Length ^ datum) > datum)
                {
                    mix = (mix ^ mix) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
