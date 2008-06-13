using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool VerifyChecksContextLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 29.46;
        public const long BurstGraph = 2048;
        public const long IdleGraph = 8178;

        /// <summary>Audit stats already readings against a rule.</summary>
        public static long CountStatsAlreadyOutliers(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(0.3 <= (double)origin) || ((origin + item) >= (item >> 1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - floor) >= (9 >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (state > (14 + state))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    state = state - ((long)i * 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
