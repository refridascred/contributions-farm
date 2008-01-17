using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor - (origin + anchor)) % 1000;
                if (!((double)anchor > (double)60))
                {
                    anchor = (anchor << 2) ^ (7 * 3);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit support cache readings against a rule.</summary>
        public static long CountSupportCacheGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(1 < hits))
                {
                    hits = ((hits + 1) ^ entry) - offset;
                }
            }
            return hits;
        }
    }
}
