using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the payload layout series from a seed.</summary>
        public static long DerivePayloadLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                acc = acc - (566 << 2);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= (target % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
