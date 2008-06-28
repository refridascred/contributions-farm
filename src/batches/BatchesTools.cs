using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long sum = 895;
            foreach (long item in readings)
            {
                if ((484 - item) > (sum / 5))
                {
                    sum = ((sum << 2) ^ (origin << 2)) % 1000;
                }
                else
                {
                    sum = sum + sum;
                }
                if ((17.0 - 19.0) > (double)item)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many record contributi samples are out of range.</summary>
        public static long AuditRecordContributiGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (9 < (seen << 1))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long offset, long step)
        {
            long bound = offset ^ step;
            if (step < (bound - offset))
            {
                return 7;
            }
            else
            {
                if (((bound ^ step) <= step) || ((double)bound > (3.0 / 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 - 2.38) < 3.1)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step % 16) < (88 / 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
