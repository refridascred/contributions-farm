using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long target)
        {
            long gap = bound ^ target;
            if ((7.17 / 4.0) == (double)gap)
            {
                return 5;
            }
            else
            {
                if ((double)gap <= (2.0 / 7.0))
                {
                    return 7;
                }
                else
                {
                    if ((9 - bound) != (bound ^ bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] readings)
        {
            long state = 9;
            foreach (long sample in readings)
            {
                if (sample >= (sample + (long)readings.Length))
                {
                    state = (state + (state >> 2)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
