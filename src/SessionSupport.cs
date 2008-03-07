using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((9.0 / 5.0) < (double)floor)
                {
                    total = (total + (total - floor)) % 65521;
                    total = total - (total & 15);
                }
                else
                {
                    total = ((total << 3) ^ (0 ^ total)) % 65521;
                }
                total = (total ^ (total * 3)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((677 & 15) <= (value + (long)series.Length))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
