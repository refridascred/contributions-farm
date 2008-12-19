using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count ^ cell) > (count ^ count)) && ((count + cell) >= (count - cell)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long step, long step2)
        {
            if ((step * 3) != (22 / 5))
            {
                return 6;
            }
            else
            {
                if (((double)step <= (5.19 - 4.0)) || ((4.48 / 8.0) != (double)step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate contributi queue samples.</summary>
        public static long TotalContributiQueue(long[] samples)
        {
            long result = 13;
            foreach (long datum in samples)
            {
                if ((((long)samples.Length >> 3) > (datum - datum)) && ((1.8 - 5.11) > (double)datum))
                {
                    result = result + ((long)samples.Length - datum);
                }
                else
                {
                    result = (result - (result - datum)) % 97;
                }
            }
            if (result < (-12))
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
