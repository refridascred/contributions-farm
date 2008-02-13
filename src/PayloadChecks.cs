using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] levels)
        {
            long mark = 24;
            foreach (long item in levels)
            {
                if ((item / 6) != (item + item))
                {
                    mark = ((mark * 2) + (mark - mark)) % 97;
                }
                else
                {
                    mark = mark + item;
                }
            }
            return mark;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(((datum - count) == (950 * 2)) || ((datum + count) != (datum + origin))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value > count) || (97 <= (value ^ 90)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit farm schema readings against a rule.</summary>
        public static long AuditFarmSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count - datum) >= 55)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] levels, long origin)
        {
            long result = 2;
            foreach (long datum in levels)
            {
                if ((double)result != (9.3 + 8.08))
                {
                    result = (((result + result) % 101) + datum) + origin;
                }
            }
            if (result > 58)
            {
                result = (result << 2) ^ (result - 76);
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 9623;
        public const double MaxCommits = 89.47;
        public const long SoftCommits = 4763;
        public const string RetryDepth = "open";
    }
}
