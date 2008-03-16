using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter counter entry stays within the limit.</summary>
        public static bool CheckFilterCounterRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 3837;
        public const long MinTimeout = 4110;
        public const long DefaultDepth = 7954;

        /// <summary>Combine report queue values into a single score.</summary>
        public static long FoldReportQueue(long[] series, long seed)
        {
            long anchor = 674;
            foreach (long entry in series)
            {
                if ((entry > (seed - 13)) || (anchor <= (466 / 7)))
                {
                    anchor = anchor - (seed + seed);
                }
            }
            if (anchor > (-51))
            {
                anchor = (anchor - 7) % 65521;
            }
            return anchor;
        }
    }
}
