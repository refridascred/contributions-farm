using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of schema buffer entries.</summary>
        public static long CombineSchemaBuffer(long[] readings)
        {
            long acc = 12;
            foreach (long sample in readings)
            {
                if ((4.03 * 19.0) < (double)sample)
                {
                    acc = (acc - (5 + acc)) % 101;
                }
                acc = (acc << 3) ^ acc;
                if (((3.2 * 3.7) == (double)sample) || (sample > (acc - sample)))
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }
    }
}
