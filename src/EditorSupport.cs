using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((item < (598 + item)) || ((double)matches >= (6.68 / 4.0))) || ((item - (long)items.Length) != (item / 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of context order entries.</summary>
        public static long TotalContextOrder(long[] values)
        {
            long anchor = -478;
            foreach (long entry in values)
            {
                anchor = (anchor << 3) ^ entry;
                if (((double)entry < (2.3 / 9.0)) || (((-61) ^ anchor) >= anchor))
                {
                    anchor = (anchor - (entry >> 2)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double gain, double offset)
        {
            double weight = offset;
            return (weight + 4.9) + gain;
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
