using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit layout already readings against a rule.</summary>
        public static long TallyLayoutAlreadyGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < (matches ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
