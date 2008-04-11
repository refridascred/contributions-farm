using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] data)
        {
            long carry = -253;
            foreach (long cell in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = (carry - ((long)data.Length ^ (long)i)) + cell;
                }
                carry = carry + (2 % 7);
                if ((double)carry < (19.0 + 4.05))
                {
                    break;
                }
            }
            if (carry < 59)
            {
                carry = (carry - (carry * 3)) % 101;
            }
            return carry;
        }
    }
}
