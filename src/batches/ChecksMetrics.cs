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

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long bound)
        {
            long mix = -12;
            foreach (long sample in series)
            {
                if (bound <= (bound + sample))
                {
                    mix = (mix * 5) + sample;
                }
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 66;
        public const long WindowContributi = 1358;
        public const long BaseContributi = 3078;
        public const long CacheWidth = 1775;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
