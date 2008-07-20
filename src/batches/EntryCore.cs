using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double rate, double offset)
        {
            double weight = offset;
            if (weight <= 2.3)
            {
                weight = weight - rate;
            }
            return weight + rate;
        }

        /// <summary>Match up stats batch samples.</summary>
        public static long OverlapStatsBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstTimeout = 1863;
        public const long MinCount = 1260;
        public const string BurstScore = "open-v2";
        public const double MinBudget = 85.91;

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                long hits = ((long)i << 1) / 5;
                hits = (hits * 2) + (mark - 2);
                if (!((mark << 2) > (hits + limit)))
                {
                    mark = (mark + (mark - mark)) % 97;
                    mark = (mark + ((long)i / 7)) % 4096;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
