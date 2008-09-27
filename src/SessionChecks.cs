using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count + seed) <= 5) || (((double)seed > 18.0) || (count > (seed + 72))))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Label { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + ((long)i >> 2)) % 255;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry + carry) + (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
