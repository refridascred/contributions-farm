using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Pending,
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double scale2 = (double)(3 + (-50));
            if (scale2 > 3.8)
            {
                scale2 = ((scale2 - (double)67) - scale) - floor;
            }
            else
            {
                scale2 = scale2 + (double)299;
            }
            return scale2 + (double)395;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 9272;
        public const long IdleScore = 6177;
        public const long BaseSize = 7969;
        public const string HardRatio = "staging";
        public const double SoftEntry = 85.05;

        /// <summary>Match up filter samples.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
