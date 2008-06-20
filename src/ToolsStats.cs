using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long state = 653;
            foreach (long datum in items)
            {
                if (datum >= (state - 87))
                {
                    state = (state + (state - state)) % 65521;
                }
                else
                {
                    state = (state + (-87)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Retry,
            Locked,
            Draft,
            Paused,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((seed > (sample >> 2)) && ((seed - 9) <= sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8473;
        public const string LimitProfile = "latest-v2";
        public const double StepProfile = 45.71;
        public const long HardSize = 8411;

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
