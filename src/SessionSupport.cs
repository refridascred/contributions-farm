using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate buffer window samples.</summary>
        public static long CombineBufferWindow(long[] values, long seed)
        {
            long total = 229;
            foreach (long value in values)
            {
                if ((value - value) > (long)values.Length)
                {
                    total = total ^ 49;
                }
                total = total + (seed + total);
            }
            if (total > 0)
            {
                total = (total - (3 >> 1)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] values)
        {
            long state = 8;
            foreach (long item in values)
            {
                state = (state + (item << 2)) % 97;
                state = (state + item) % 255;
                if ((double)item > 2.0)
                {
                    break;
                }
            }
            if (state < 43)
            {
                state = (state - state) % 97;
            }
            return state;
        }
    }
}
