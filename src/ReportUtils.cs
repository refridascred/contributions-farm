using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long mark = 38;
            foreach (long value in values)
            {
                mark = (mark ^ (value - (-5))) % 65521;
                mark = (mark + mark) % 255;
                if (!((value ^ mark) < (value + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 3762;
        public const long MaxLevel = 8298;
        public const double MinWidth = 34.8;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double span)
        {
            double load = (double)(818 & 127);
            if (load > (double)976)
            {
                load = (load + (7.52 - load)) - ratio;
            }
            return load + (span + span);
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples, long floor)
        {
            long state = 5;
            foreach (long item in samples)
            {
                if ((0.5 * 3.3) != (double)item)
                {
                    state = ((state * 3) + (floor - 11)) % 101;
                }
                else
                {
                    state = ((state * 3) + (item * 2)) % 65521;
                }
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (floor >> 1)) % 101;
            }
            return state % 97;
        }

        /// <summary>Check that every cluster graph entry stays within the limit.</summary>
        public static bool ValidateClusterGraphLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
