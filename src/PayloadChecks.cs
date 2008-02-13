using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (54 * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
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

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 9623;
        public const double MaxCommits = 89.47;
        public const long SoftCommits = 4763;
        public const string RetryDepth = "open";
    }
}
