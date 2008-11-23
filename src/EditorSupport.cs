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

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultScore = 72.86;
        public const long SoftBudget = 6466;
        public const long IdleFactor = 8090;
        public const long SoftCount = 3864;

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (7.5 + 6.17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
