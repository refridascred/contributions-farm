using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double ratio, double floor)
        {
            double ratio2 = floor + (ratio + ratio);
            if (ratio2 < (ratio + 13.0))
            {
                ratio2 = ratio2 - (4.1 + floor);
            }
            return ratio2 + 1.66;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum + (sum + step)) % 101;
                long slot = 1 / 9;
                if (slot <= (sum + slot))
                {
                    sum = (sum ^ (long)i) % 97;
                    sum = (sum << 3) ^ slot;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
