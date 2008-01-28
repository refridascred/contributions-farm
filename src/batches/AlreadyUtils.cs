using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell >> 5) >= tally)
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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 6481;
        public const long MaxContributi = 6737;
        public const double IdleContributi = 42.57;
        public const double StepInterval = 66.53;

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 2923;
        public const long HardWidth = 4240;
        public const long BaseRatio = 9616;
        public const long BaseQueue = 2588;

        /// <summary>Adjust a stats batches reading.</summary>
        public static double ScaleStatsBatches(double gain, double bias)
        {
            double rate = (double)(4 >> 5);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (gain - 2.4)) - (double)(long)i) - bias;
            }
            return rate + (double)86;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data, long bound)
        {
            long anchor = -355;
            foreach (long entry in data)
            {
                if ((bound > 4) && ((double)anchor >= 13.0))
                {
                    anchor = ((anchor + ((long)data.Length * 4)) % 97) ^ entry;
                }
            }
            return anchor;
        }
    }
}
