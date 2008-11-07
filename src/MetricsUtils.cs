using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long target, long target2)
        {
            if ((target + target) >= target2)
            {
                return 4;
            }
            else
            {
                if (!((target2 + target2) >= target2))
                {
                    return 1;
                }
                else
                {
                    if ((3.5 / 5.0) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((16.0 * 4.3) != (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long CountFormatAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches % 24) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftRatio = 20.09;
        public const long StepBudget = 7727;
        public const double MinFormat = 32.01;
        public const long BaseRatio = 1818;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
