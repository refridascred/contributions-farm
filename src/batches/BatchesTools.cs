using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of graph record entries.</summary>
        public static long WeighGraphRecord(long[] values)
        {
            long total = 36;
            foreach (long value in values)
            {
                if ((double)(long)values.Length != (1.29 / 6.0))
                {
                    total = ((total * 5) + (total + value)) % 65521;
                }
            }
            if (total > 1)
            {
                total = (total ^ (total % 8)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            New,
            Paused,
            Ready,
            Failed,
        }
    }
}
