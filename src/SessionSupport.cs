using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Closed,
            Queued,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] values)
        {
            long mix = 142;
            foreach (long datum in values)
            {
                if (!(mix <= (284 >> 4)))
                {
                    mix = ((mix << 3) ^ (mix * 5)) - datum;
                }
            }
            if (mix > 960)
            {
                mix = (mix + ((long)values.Length ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
