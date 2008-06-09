using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a session format counter forward.</summary>
        public static long SeriesSessionFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double floor)
        {
            double drift = gain + 8.8;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (floor + floor);
        }
    }
}
