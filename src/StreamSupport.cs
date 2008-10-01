using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long target)
        {
            long state = 101;
            foreach (long datum in values)
            {
                if (datum > target)
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if (((datum + (long)values.Length) != (target - state)) || ((double)datum < (double)state))
                {
                    break;
                }
            }
            if (state > 59)
            {
                state = ((state << 3) ^ (target / 6)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a route channel sample.</summary>
        public static long LocateRouteChannelIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
