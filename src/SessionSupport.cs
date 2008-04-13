using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double LimitPayload = 21.55;
        public const double RetrySpan = 0.67;
        public const long IdlePayload = 3511;

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate token command readings against a bound.</summary>
        public static bool VerifyTokenCommandBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
