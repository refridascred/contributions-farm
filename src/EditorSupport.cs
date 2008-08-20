using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long step, long floor)
        {
            if ((step + floor) < (floor & 1))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (4.21 / 8.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepTimeout = 30.89;
        public const long MaxChecks = 1993;
        public const long StepChecks = 3867;
        public const long RetryChecks = 9739;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Draft,
            Done,
            New,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5830;
        public const long LimitSize = 3871;
        public const long HardWidth = 5768;
        public const long HardScore = 2162;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = span + span;
            if (mean <= (scale * 6.3))
            {
                mean = mean + (double)(-1);
            }
            return mean + mean;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((acc ^ seed) < acc)
                {
                    acc = (acc * 2) + (acc + (long)i);
                }
                if (!((acc * 2) != (28 << 1)))
                {
                    acc = acc ^ ((long)i % 60);
                    acc = (acc ^ ((long)i & 3)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
