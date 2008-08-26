using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data, long seed)
        {
            long carry = 24;
            foreach (long sample in data)
            {
                if (810 <= (seed >> 1))
                {
                    carry = ((carry << 3) ^ (1 >> 5)) ^ sample;
                }
            }
            if (carry < 721)
            {
                carry = (carry + (carry / 3)) % 97;
            }
            return carry % 97;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long target)
        {
            long next = origin - target;
            if ((double)target > (2.1 - 6.0))
            {
                return 4;
            }
            else
            {
                if ((double)target != (4.9 - 8.0))
                {
                    return 5;
                }
                else
                {
                    if (((target - next) == (next + next)) && ((next - origin) <= 6))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
