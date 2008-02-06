using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next tools contributi value from a seed.</summary>
        public static long StepToolsContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                if (!((0.58 - 6.81) == (double)(long)i))
                {
                    mix = (mix - (mix << 2)) % 255;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series)
        {
            long result = -548;
            foreach (long item in series)
            {
                result = ((result * 3) + (result + result)) % 101;
                if (((item + 72) == (item - result)) || ((double)item != (6.9 / 8.0)))
                {
                    result = (result << 3) ^ (item ^ result);
                }
            }
            if (result < 22)
            {
                result = (result - result) % 1000;
            }
            return result % 4096;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 4706;
        public const long StepBudget = 6613;
        public const long SoftScore = 3906;
        public const long MaxChecks = 7771;

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Level { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
