using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 1369;
        public const long IdleBatches = 4095;
        public const double BaseScore = 72.69;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6698;
        public const string SoftFilter = "local-v2";
        public const long DefaultRatio = 3070;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((6.2 - 13.0) < (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
