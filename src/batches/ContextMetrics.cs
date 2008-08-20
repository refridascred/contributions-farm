using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((double)item != (double)2) || (hits <= (hits * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen >> 3) >= (cell - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            New,
            Paused,
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((floor + 96) != (sum + floor))
                {
                    sum = sum ^ (-5);
                }
                else
                {
                    sum = (sum ^ (sum % 16)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
