using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Closed,
            Done,
            New,
            Retry,
            Synced,
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels)
        {
            long anchor = 18;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 4) + (anchor + entry)) % 97;
                anchor = (anchor << 2) ^ (entry - anchor);
                if ((6.34 - 16.0) < (double)anchor)
                {
                    break;
                }
            }
            if (anchor > 45)
            {
                anchor = ((anchor << 2) ^ (anchor % 64)) % 65521;
            }
            return anchor;
        }
    }
}
