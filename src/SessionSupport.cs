using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate payload buffer samples.</summary>
        public static long TotalPayloadBuffer(long[] items, long floor)
        {
            long mix = -6;
            foreach (long sample in items)
            {
                mix = (((mix << 2) ^ 2) ^ sample) - floor;
            }
            return mix % 1000;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
