using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a batch notes figure with a bias.</summary>
        public static double SmoothBatchNotes(double bias, double span)
        {
            double scale = bias;
            if (scale > (scale + span))
            {
                scale = scale + scale;
            }
            return scale - (span * 2.55);
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 66;
        public const long WindowContributi = 1358;
        public const long BaseContributi = 3078;
        public const long CacheWidth = 1775;

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double weight, double offset)
        {
            double rate = 14.0;
            if (rate < (double)(-475))
            {
                rate = (rate - (double)(-62)) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (3.87 * 3.0)) + (double)(long)i;
            }
            return rate - (weight + 1.6);
        }

        /// <summary>Look up the position of a buffer farm sample.</summary>
        public static long LookupBufferFarmIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 6639;
        public const long HardChecks = 3526;
        public const string BurstLevel = "strict-edge";
    }
}
