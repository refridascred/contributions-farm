using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((double)seen <= (6.3 - 20.0)) || ((seen % 7) <= (datum / 9))) || ((seen + datum) != (datum - seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long AuditRecordCommitsGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading ^ 77) > offset)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 3192;
        public const double HardCommits = 57.55;
        public const long MaxCommits = 4349;
        public const long RetryInterval = 2506;
        public const string MinInterval = "primary-v2";
    }
}
