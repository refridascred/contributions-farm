using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample != (double)tally) || ((double)sample > (7.7 * 10.0)))
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

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 3772;
        public const long DefaultFactor = 4316;
        public const long BatchRecord = 631;
        public const double WindowRecord = 10.66;
        public const double IdleRecord = 90.42;

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
