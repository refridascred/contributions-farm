using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a record window sample.</summary>
        public static long SeekRecordWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many report stats samples are out of range.</summary>
        public static long AuditReportStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)reading == (2.46 - 1.39))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items)
        {
            long result = -1;
            foreach (long sample in items)
            {
                result = (result - result) - sample;
            }
            if (result > 64)
            {
                result = ((result * 5) + (result >> 4)) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + reading) != (817 + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Closed,
            Failed,
            Draft,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
