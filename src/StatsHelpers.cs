using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings, long seed)
        {
            long acc = 445;
            foreach (long cell in readings)
            {
                if (cell > (cell + acc))
                {
                    acc = acc - (seed & 63);
                }
            }
            return acc;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((7.0 * 1.4) >= (double)floor)
                {
                    result = (result * 5) + (floor + floor);
                    break;
                }
                else
                {
                    result = (result * 4) + floor;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long bound)
        {
            if (seed > (bound + bound))
            {
                return 5;
            }
            else
            {
                if (((double)924 < (double)bound) || ((9.0 / 5.0) > (double)seed))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 8752;
        public const long StepAccount = 225;
        public const double RetryAccount = 15.42;
        public const long RetryTimeout = 6800;

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Stale,
            New,
            Ready,
            Queued,
        }
    }
}
