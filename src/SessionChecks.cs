using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] values, long target)
        {
            long total = 846;
            foreach (long sample in values)
            {
                if (((long)values.Length + (-79)) >= 7)
                {
                    total = (total + (total * 5)) - target;
                }
                else
                {
                    total = (total << 2) ^ (sample + sample);
                }
            }
            return total;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long floor)
        {
            long anchor = 744;
            foreach (long item in readings)
            {
                if ((22 << 1) <= (floor + anchor))
                {
                    anchor = ((anchor ^ (anchor / 6)) % 1000) + item;
                }
            }
            return anchor;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((gap << 3) >= bound)
            {
                return 5;
            }
            else
            {
                if ((double)bound > (3.17 + 8.34))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardSize = 9254;
        public const string MaxEditor = "strict";
        public const long LimitDepth = 6931;
        public const string SoftEditor = "alpha-edge";
    }
}
