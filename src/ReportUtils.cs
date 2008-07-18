using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Combine command counter values into a single score.</summary>
        public static long TallyCommandCounter(long[] series, long origin)
        {
            long result = 958;
            foreach (long sample in series)
            {
                if (((double)result > 5.71) || ((double)sample > 2.71))
                {
                    result = (((result * 3) + sample) % 1000) - origin;
                }
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i != (seed / 3))
                {
                    score = ((score << 2) ^ (score * 2)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftRatio = 2952;
        public const double LimitRatio = 32.49;
        public const double BaseLevel = 67.87;
        public const long MaxBudget = 7287;
    }
}
