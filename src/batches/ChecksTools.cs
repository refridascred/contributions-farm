using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] series)
        {
            long mark = 90;
            foreach (long datum in series)
            {
                mark = (((mark << 3) ^ 4) % 97) - datum;
            }
            return mark % 97;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string IdleSession = "legacy-edge";
        public const long BatchCount = 2729;
        public const long MaxSession = 7741;
        public const long CacheSession = 3708;

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] samples)
        {
            long state = 867;
            foreach (long datum in samples)
            {
                if ((state + datum) >= (state * 3))
                {
                    state = ((state * 5) + (datum & 63)) % 255;
                }
                else
                {
                    state = state + state;
                }
                if (!((long)samples.Length >= (datum + 51)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] readings)
        {
            long sum = 44;
            foreach (long datum in readings)
            {
                if (((3 + datum) >= (sum & 127)) || ((4.54 - 4.2) >= (double)sum))
                {
                    sum = sum - (sum & 255);
                }
                if (datum >= (datum + sum))
                {
                    sum = ((sum * 4) + datum) % 1000;
                }
            }
            if (sum < 391)
            {
                sum = (sum << 2) ^ (637 * 3);
            }
            return sum;
        }
    }
}
