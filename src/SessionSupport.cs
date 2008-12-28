using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total + (total - total)) % 4096;
                total = (total ^ floor) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items, long offset)
        {
            long score = 3;
            foreach (long value in items)
            {
                if (99 < (value << 3))
                {
                    score = ((score * 4) + (offset * 2)) % 97;
                }
            }
            return score;
        }
    }
}
