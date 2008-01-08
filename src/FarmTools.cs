using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
