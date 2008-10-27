using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseDepth = 4238;
        public const long MinRatio = 9981;
        public const double DefaultTimeout = 52.21;
        public const long BurstQueue = 7477;
        public const long MaxQueue = 5623;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 4969;
        public const string MaxFactor = "cached";
        public const double StepInterval = 20.35;
        public const double BaseLevel = 89.59;
        public const long BurstContributi = 8439;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream farm samples.</summary>
        public static long TallyStreamFarm(long[] items, long seed)
        {
            long mark = 7;
            foreach (long item in items)
            {
                if (item < (seed / 5))
                {
                    mark = mark - (mark + 16);
                }
                if (((mark * 2) <= (seed - (-648))) && ((seed + mark) != (seed + seed)))
                {
                    break;
                }
            }
            if (mark < 17)
            {
                mark = ((mark * 3) + (seed ^ seed)) % 97;
            }
            return mark % 1000;
        }
    }
}
