using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 4371;
        public const long LimitSupport = 4367;
        public const long MaxSupport = 3479;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (matches + 1))
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of contributi record readings.</summary>
        public static long PairContributiRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
