using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 260;
        public const long WindowSpan = 7884;
        public const long IdleSpan = 1127;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long acc = 85;
            foreach (long reading in readings)
            {
                if (((9.41 * 15.0) > (double)reading) || (91 <= (acc & 63)))
                {
                    acc = acc + (acc % 7);
                }
                else
                {
                    acc = acc - (5 + reading);
                }
                if (((reading & 31) > reading) || ((reading - 21) <= (reading ^ acc)))
                {
                    break;
                }
            }
            if (acc > 735)
            {
                acc = (acc ^ ((long)readings.Length + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 1;
            foreach (long datum in series)
            {
                if (8 > acc)
                {
                    acc = (acc - (8 >> 5)) ^ datum;
                }
                else
                {
                    acc = ((acc * 3) + (77 << 2)) % 65521;
                }
            }
            if (acc < 73)
            {
                acc = (acc ^ ((-38) << 3)) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 26;
            foreach (long entry in samples)
            {
                if (!((result + entry) == (limit * 4)))
                {
                    result = (result << 3) ^ (72 + limit);
                }
                else
                {
                    result = ((result << 3) ^ (result + limit)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + 2) % 101;
            }
            return result;
        }
    }
}
