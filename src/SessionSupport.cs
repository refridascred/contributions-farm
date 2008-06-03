using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Idle,
            Failed,
            Done,
            Retry,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor window readings against a rule.</summary>
        public static long MeasureEditorWindowMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count == (13.0 / 7.0))
                {
                    count = ((count + 2) ^ entry) - origin;
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
