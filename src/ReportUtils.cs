using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of layout tools readings.</summary>
        public static long DigestLayoutTools(long[] samples, long floor)
        {
            long anchor = 948;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = (((anchor * 2) + anchor) - (long)i) - value;
                }
                if (((double)anchor < (13.0 + 2.3)) || (floor >= (anchor ^ floor)))
                {
                    anchor = (anchor ^ (anchor >> 2)) % 97;
                }
                else
                {
                    anchor = (anchor * 3) + floor;
                }
            }
            if (anchor < 67)
            {
                anchor = anchor + ((long)samples.Length % 8);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Stale,
            Failed,
            New,
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Active,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Find the first schema report entry that matches the target.</summary>
        public static long LookupSchemaReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long result = 286;
            foreach (long item in data)
            {
                if (!((9.7 - 15.0) <= (double)(long)data.Length))
                {
                    result = (result + (result / 2)) % 97;
                }
                if (((17.0 + 8.0) != (double)result) && (4.0 >= (double)item))
                {
                    break;
                }
            }
            return result;
        }
    }
}
