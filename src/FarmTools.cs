using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of stats farm readings.</summary>
        public static long MatchStatsFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Retry,
            Ready,
            Pending,
            Active,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((49 >> 2) != (step - datum))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
