using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Failed,
            Idle,
            Retry,
            Synced,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Adjust a report queue reading.</summary>
        public static double BlendReportQueue(double scale, double floor)
        {
            double ratio = scale + scale;
            if (ratio < floor)
            {
                ratio = ratio - (double)37;
            }
            return ratio + floor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] levels, long origin)
        {
            long mark = 60;
            foreach (long datum in levels)
            {
                mark = ((mark + (mark - 113)) % 65521) - origin;
                if ((double)datum > (double)mark)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
