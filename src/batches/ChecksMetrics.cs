using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] items, long offset)
        {
            long acc = 7;
            foreach (long entry in items)
            {
                acc = ((acc + acc) + entry) + offset;
            }
            return acc % 1000;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] levels, long seed)
        {
            long result = -6;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result + datum)) + seed;
            }
            return result % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryLevel = 16.47;
        public const long MinInterval = 679;
        public const long MaxStats = 8766;
        public const long IdleStats = 2441;
        public const double MinStats = 30.14;

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double bias, double span)
        {
            double scale = span;
            if (scale > span)
            {
                scale = scale - (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (bias / 6.0)) + (double)(long)i;
            }
            return scale + (double)48;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result << 3) ^ (target * 4);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc << 3) ^ (offset * 3)) % 97;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
