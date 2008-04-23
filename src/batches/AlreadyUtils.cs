using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count buffer notes pairs that satisfy a relation.</summary>
        public static long CompareBufferNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 <= (gain + gain2))
            {
                gain2 = (gain2 + (double)829) + offset;
            }
            return gain2 - gain;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 8849;
        public const long MaxSpan = 3917;
        public const string HardCount = "standard-1";
        public const long RetryRecord = 417;
        public const long CacheRecord = 3906;

        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleWidth = "fallback-1";
        public const double MinTools = 49.7;
        public const double WindowRatio = 11.08;
        public const long BaseTools = 1630;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
