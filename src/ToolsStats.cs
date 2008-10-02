using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Offset { get; set; }
            public bool Weight { get; set; }
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 72) > count)
                {
                    count = count + 2;
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

        /// <summary>Rank record command input into a small class.</summary>
        public static long SortRecordCommand(long target, long origin)
        {
            if ((target << 2) < (target + origin))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 5.0) >= (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((target >= (origin % 2)) && ((target / 3) == (origin >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!(origin >= (target + origin)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
