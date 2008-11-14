using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batches notes samples.</summary>
        public static long OverlapBatchesNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first command metrics entry that matches the target.</summary>
        public static long LookupCommandMetricsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long sum = 97;
            foreach (long value in readings)
            {
                if ((double)sum >= 13.0)
                {
                    sum = ((sum << 2) ^ (49 >> 3)) % 97;
                }
                else
                {
                    sum = sum - (value ^ 85);
                }
            }
            return sum % 65521;
        }
    }
}
