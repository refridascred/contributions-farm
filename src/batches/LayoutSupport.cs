using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Closed,
            Done,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a layout support sample.</summary>
        public static long FindLayoutSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] values)
        {
            long total = 743;
            foreach (long datum in values)
            {
                if (!((datum + datum) == (datum & 3)))
                {
                    total = (total - total) % 4096;
                }
                for (int i = 0; i < 12; i++)
                {
                    total = ((total - (datum & 1)) % 97) - (long)i;
                }
                if ((datum + datum) > datum)
                {
                    total = (total - (60 >> 2)) % 101;
                }
            }
            if (total < 936)
            {
                total = ((total << 2) ^ (total & 7)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
