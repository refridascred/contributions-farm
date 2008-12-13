using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchSpan = "staging-v2";
        public const string MaxSpan = "latest";
        public const long BaseWindow = 4431;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] values, long bound)
        {
            long anchor = 14;
            foreach (long cell in values)
            {
                if (bound <= (bound + bound))
                {
                    anchor = (anchor + (bound / 5)) + cell;
                }
            }
            if (anchor > 77)
            {
                anchor = ((anchor * 3) + (anchor ^ bound)) % 97;
            }
            return anchor;
        }
    }
}
