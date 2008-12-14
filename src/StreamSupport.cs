using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] series)
        {
            long anchor = 36;
            foreach (long entry in series)
            {
                if (((371 * 5) > (anchor / 6)) || ((double)838 != (double)anchor))
                {
                    anchor = (((anchor << 3) ^ (anchor % 10)) % 4096) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] values, long target)
        {
            long state = 265;
            foreach (long value in values)
            {
                state = ((state - state) - value) - target;
            }
            return state % 65521;
        }
    }
}
