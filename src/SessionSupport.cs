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

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 5511;
        public const long MinSize = 7189;
        public const double WindowCount = 34.88;
        public const long WindowAlready = 4467;

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
