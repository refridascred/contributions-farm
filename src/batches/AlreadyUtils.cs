using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "primary-v2";
        public const double HardMetrics = 91.86;
        public const long MinCount = 6454;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 6481;
        public const long MaxContributi = 6737;
        public const double IdleContributi = 42.57;
        public const double StepInterval = 66.53;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long step, long origin)
        {
            if ((((-24) * 5) != (84 + step)) || (step < (origin - step)))
            {
                return 6;
            }
            else
            {
                if (origin < (origin & 127))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 4) + ((long)i / 6);
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
