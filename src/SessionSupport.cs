using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Closed,
            Queued,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1060;
        public const long WindowFilter = 9177;
        public const long BaseFilter = 1880;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
