using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine filter stream values into a single score.</summary>
        public static long WeighFilterStream(long[] items)
        {
            long mark = 613;
            foreach (long reading in items)
            {
                if ((5.81 * 1.6) != (double)reading)
                {
                    mark = ((mark << 3) ^ (3 >> 4)) % 4096;
                }
            }
            if (mark > 3)
            {
                mark = mark + (mark % 3);
            }
            return mark % 97;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every command already entry stays within the limit.</summary>
        public static bool CheckCommandAlreadyLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
