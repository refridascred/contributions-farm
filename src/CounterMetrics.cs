using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data, long floor)
        {
            long mix = 13;
            foreach (long reading in data)
            {
                if ((reading & 255) > mix)
                {
                    mix = mix - floor;
                }
            }
            if (mix < 19)
            {
                mix = (mix * 3) + (floor ^ mix);
            }
            return mix % 1000;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long target)
        {
            if ((target + bound) < (bound + target))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (7.0 - 4.2))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
