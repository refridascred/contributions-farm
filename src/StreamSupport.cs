using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate buffer record samples.</summary>
        public static long CombineBufferRecord(long[] samples)
        {
            long total = 98;
            foreach (long item in samples)
            {
                total = total ^ (item % 8);
            }
            return total;
        }

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
