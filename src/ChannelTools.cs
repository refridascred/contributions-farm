using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((1.2 / 6.0) < (double)count)
                {
                    count = ((count + 3) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
