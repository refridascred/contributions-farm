using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                carry = carry ^ (carry % 16);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Owner { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (target + target)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor + (target + target)) - (long)i2;
                }
                anchor = anchor - (target * 3);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 5.01;
        public const long RetryChannel = 5043;
        public const long LimitRatio = 9636;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading + tally) <= (reading + reading))
                {
                    tally = (tally + 1) + origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] samples)
        {
            long acc = 587;
            foreach (long item in samples)
            {
                if (5 <= (item % 97))
                {
                    acc = (acc ^ (item % 10)) % 1000;
                }
                if ((double)item > 1.1)
                {
                    break;
                }
            }
            return acc;
        }
    }
}
