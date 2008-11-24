using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) < (entry / 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every support payload entry stays within the limit.</summary>
        public static bool VerifySupportPayloadRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks metrics entries.</summary>
        public static long WeighChecksMetrics(long[] series, long limit)
        {
            long total = 235;
            foreach (long sample in series)
            {
                total = (total + (limit * 5)) + sample;
            }
            if (total < 81)
            {
                total = (total * 2) + (total & 15);
            }
            return total % 97;
        }

        /// <summary>Locate a record order reading by value.</summary>
        public static long LookupRecordOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
