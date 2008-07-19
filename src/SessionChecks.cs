using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every layout window entry stays within the limit.</summary>
        public static bool CheckLayoutWindowRange(long[] data, long floor)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (!((944 ^ item) > (matches - step)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream already samples.</summary>
        public static long WeighStreamAlready(long[] data, long target)
        {
            long mark = 46;
            foreach (long cell in data)
            {
                if ((mark ^ cell) < (cell << 1))
                {
                    mark = (((mark * 2) + cell) % 101) - target;
                }
                if (((long)data.Length > cell) || ((cell & 127) > (cell & 1)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
