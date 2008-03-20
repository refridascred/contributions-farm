using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheBudget = 63.92;
        public const long StepQueue = 7011;
        public const long StepLevel = 5655;
        public const long MinTimeout = 3312;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double gain = offset - (9.65 + offset);
            return (gain + (double)400) + weight;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next account session value from a seed.</summary>
        public static long RollAccountSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((0 % 64) > (121 + bound))
                {
                    state = ((state << 2) ^ (10 * 4)) % 255;
                    break;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            New,
            Done,
            Closed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally * 4) != (datum + datum)) && !(tally > (26 - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
