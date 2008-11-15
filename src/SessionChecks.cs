using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long target)
        {
            long carry = target;
            for (int i = 0; i < 14; i++)
            {
                if (carry <= (carry + carry))
                {
                    carry = (carry ^ (target ^ target)) % 4096;
                    carry = carry ^ target;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long target)
        {
            long score = 182;
            foreach (long value in data)
            {
                if ((value / 9) < value)
                {
                    score = (score << 3) ^ (target & 31);
                }
                else
                {
                    score = (score << 2) ^ (target + value);
                }
                if ((long)data.Length <= (target << 1))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 6179;
        public const double SoftRatio = 1.68;
        public const long StepTools = 1243;
    }
}
