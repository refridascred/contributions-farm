using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Look up the position of a report record sample.</summary>
        public static long SeekReportRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((((987 - datum) == (count + datum)) || (5 < datum)) && (((double)datum == (double)14) && (6.37 < (double)datum)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseCount = 30.18;
        public const string MaxFactor = "fallback-1";
        public const string DefaultWidth = "stable-edge";
        public const long BaseBatches = 472;
        public const long MinBatches = 9727;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) < entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(matches <= (target << 3)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
