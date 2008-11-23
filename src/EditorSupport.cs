using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Idle,
            Active,
            Done,
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Pending,
            Draft,
            Done,
            Ready,
            Retry,
        }

        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long LocateCacheContributiIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile window entries.</summary>
        public static long FoldProfileWindow(long[] readings)
        {
            long state = -4;
            foreach (long entry in readings)
            {
                state = (state << 2) ^ entry;
            }
            return state;
        }

        /// <summary>Audit graph window readings against a rule.</summary>
        public static long AuditGraphWindowMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (269 < (sample << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
