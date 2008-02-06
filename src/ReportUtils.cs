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

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] levels, long step)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = (acc - (step - 92)) - value;
                acc = acc ^ acc;
                if ((double)acc >= 8.1)
                {
                    acc = ((acc << 3) ^ 692) % 65521;
                }
            }
            return acc;
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
