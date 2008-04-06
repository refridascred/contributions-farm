using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((double)0 == (double)datum) && ((count + datum) >= (datum % 3)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
