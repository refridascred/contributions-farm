using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count contributi counter pairs that satisfy a relation.</summary>
        public static long CompareContributiCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstWidth = 9203;
        public const long CacheEditor = 1197;
        public const long BurstEditor = 7342;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!((1.7 / 9.0) < (double)carry))
                {
                    carry = (carry - (long)i) % 1000;
                    carry = (carry ^ (long)i) % 97;
                }
                else
                {
                    carry = (carry ^ ((long)i >> 3)) % 101;
                }
                if ((long)i >= (893 >> 5))
                {
                    carry = carry + (carry + carry);
                    carry = (carry - (floor >> 4)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 97;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= (7.9 * 3.1))
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }
    }
}
