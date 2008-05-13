using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a filter report reading by value.</summary>
        public static long LookupFilterReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long bound, long limit)
        {
            if (((double)bound != (double)limit) || ((bound ^ limit) <= (limit * 2)))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) <= bound)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 7) > limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((sample / 4) > target) || (target >= (target % 60)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((51 + (-9)) >= (value & 255))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
