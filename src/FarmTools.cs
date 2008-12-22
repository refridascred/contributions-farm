using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((total + 8) == (bound % 16))
                {
                    total = ((total << 3) ^ bound) % 65521;
                    total = total - ((long)i & 63);
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Weight { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
