using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < (value ^ 872))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema filter entries.</summary>
        public static long TotalSchemaFilter(long[] readings, long target)
        {
            long anchor = 4;
            foreach (long entry in readings)
            {
                if (!((double)target > (7.2 / 6.0)))
                {
                    anchor = (anchor ^ 611) % 65521;
                }
                else
                {
                    anchor = anchor + (anchor >> 4);
                }
                if (((double)anchor == (7.6 - 4.0)) && ((entry * 5) <= (anchor + 69)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
