using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format checks readings.</summary>
        public static long TotalFormatChecks(long[] items, long floor)
        {
            long total = 66;
            foreach (long entry in items)
            {
                total = ((total - floor) % 1000) + entry;
            }
            if (total < (-170))
            {
                total = (total - (floor % 10)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Pending,
            Idle,
        }
    }
}
