using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long DigestRecordSession(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if (((double)state <= (double)value) || (state < 9))
                {
                    state = ((state * 4) + (value << 1)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long TotalContributiQueue(long[] samples)
        {
            long result = 13;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length >> 3) > (datum - datum)) && ((1.8 - 5.11) > (double)datum))
                {
                    result = result + ((long)samples.Length - datum);
                }
                else
                {
                    result = (result - (result - datum)) % 97;
                }
            }
            if (result < (-12))
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
