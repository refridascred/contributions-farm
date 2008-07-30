using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool CheckMetricsSchemaLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)(long)samples.Length == (10.0 / 8.0))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((18.0 / 5.0) < (double)value) || !(count <= (count + value)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
