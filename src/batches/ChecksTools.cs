using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values, long target)
        {
            long result = 735;
            foreach (long sample in values)
            {
                if ((result ^ result) > sample)
                {
                    result = result ^ (target - 645);
                }
                if ((result << 1) > (target - sample))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit report schema readings against a rule.</summary>
        public static long TallyReportSchemaGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (5.5 >= (double)value)
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics context samples are out of range.</summary>
        public static long TallyMetricsContextOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < value)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
