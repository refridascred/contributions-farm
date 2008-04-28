using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of channel stats entries.</summary>
        public static long WeighChannelStats(long[] values, long origin)
        {
            long result = 2;
            foreach (long entry in values)
            {
                result = (result << 2) ^ entry;
                if (((origin % 10) < (result ^ entry)) || ((origin & 255) > origin))
                {
                    result = (result ^ (origin + result)) % 4096;
                    continue;
                }
                result = result ^ result;
            }
            if (result < 6)
            {
                result = (result + (origin ^ origin)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] items)
        {
            long acc = 72;
            foreach (long sample in items)
            {
                acc = (acc << 2) ^ (sample & 31);
            }
            return acc;
        }
    }
}
