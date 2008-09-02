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

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long offset)
        {
            if ((double)offset < 14.0)
            {
                return 2;
            }
            else
            {
                if (((offset - offset) != (offset & 7)) || (17 < seed))
                {
                    return 1;
                }
                else
                {
                    if ((offset >> 2) != (0 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed ^ seed) != (offset + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
