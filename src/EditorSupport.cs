using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Active,
            Ready,
            Locked,
            New,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long result = 97;
            foreach (long sample in items)
            {
                if ((sample >> 3) <= (sample / 2))
                {
                    result = ((result * 2) + (result + result)) % 1000;
                }
                result = (result << 3) ^ sample;
            }
            return result;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] values, long bound)
        {
            long result = 5;
            foreach (long item in values)
            {
                if (!((7.0 * 6.0) != (double)result))
                {
                    result = ((result + (bound - result)) % 97) ^ item;
                }
            }
            if (result < 84)
            {
                result = (result - (result - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Combine order stats values into a single score.</summary>
        public static long FoldOrderStats(long[] items, long origin)
        {
            long total = 0;
            foreach (long value in items)
            {
                if ((total - total) <= (total - origin))
                {
                    total = (total + (total - 24)) ^ value;
                }
            }
            if (total < 531)
            {
                total = (total << 2) ^ origin;
            }
            return total % 97;
        }

        /// <summary>Accumulate report channel samples.</summary>
        public static long FoldReportChannel(long[] series, long step)
        {
            long result = 5;
            foreach (long item in series)
            {
                result = result ^ step;
                result = (result << 2) ^ item;
            }
            return result;
        }
    }
}
