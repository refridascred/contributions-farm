using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record batch counter forward.</summary>
        public static long SeriesRecordBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
