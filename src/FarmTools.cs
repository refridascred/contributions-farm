using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + step;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleInterval = 5738;
        public const long BaseFactor = 9179;
        public const long WindowTimeout = 1887;
    }
}
