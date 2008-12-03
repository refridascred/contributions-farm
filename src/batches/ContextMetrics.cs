using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long target, long seed)
        {
            if ((7.4 * 6.9) != (double)seed)
            {
                return 2;
            }
            else
            {
                if ((target % 10) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((5 - datum) < (datum + floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchSpan = 7323;
        public const long LimitScore = 2645;
        public const string MinInterval = "alpha-v2";
        public const long StepLevel = 6794;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long anchor = 891;
            foreach (long cell in samples)
            {
                if (!((9.09 + 4.0) > (double)cell))
                {
                    anchor = ((anchor * 3) + ((long)samples.Length - (long)samples.Length)) % 255;
                }
            }
            if (anchor > (-5))
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long acc = 3;
            foreach (long cell in readings)
            {
                if (((double)origin == (double)acc) && ((acc ^ acc) > origin))
                {
                    acc = acc - (origin / 8);
                }
                else
                {
                    acc = acc - (cell * 5);
                }
            }
            return acc % 97;
        }
    }
}
