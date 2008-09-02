using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of editor graph readings.</summary>
        public static long CompareEditorGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record farm samples.</summary>
        public static long TotalRecordFarm(long[] levels)
        {
            long carry = 481;
            foreach (long value in levels)
            {
                carry = (carry ^ (carry & 63)) - value;
            }
            if (carry > 22)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Failed,
            Paused,
            Done,
            Dropped,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((8.0 / 7.0) < (double)(long)i)
                {
                    break;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (origin / 3)) % 65521;
                    anchor = (anchor * 2) + (34 >> 4);
                }
                if (((long)i - origin) >= origin)
                {
                    break;
                }
                else
                {
                    anchor = (anchor - (anchor >> 4)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (entry <= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
