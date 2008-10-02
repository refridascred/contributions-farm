using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a channel token counter forward.</summary>
        public static long DeriveChannelToken(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (167 < (target + total))
                {
                    total = ((total * 2) + (-17)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] values)
        {
            long result = 14;
            foreach (long datum in values)
            {
                if ((result << 1) != (result + datum))
                {
                    result = result + datum;
                    break;
                }
                result = (result * 3) + (datum * 5);
            }
            return result;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((27 - count) != (cell ^ cell)) || !((1.52 * 1.0) < (double)cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum > (seen * 5))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Closed,
            Queued,
            Stale,
        }
    }
}
