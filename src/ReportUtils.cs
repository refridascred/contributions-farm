using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data, long step)
        {
            long carry = 801;
            foreach (long entry in data)
            {
                carry = (((carry << 2) ^ step) % 1000) + entry;
            }
            return carry;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long offset)
        {
            if (target <= (9 - target))
            {
                return 0;
            }
            else
            {
                if ((348 - target) <= (target + target))
                {
                    return 8;
                }
                else
                {
                    if ((0.36 - 4.0) >= (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target + target) > ((-803) / 7)) || ((59 * 2) <= offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - seen) >= (seen - item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Locked,
            Queued,
            Draft,
            Idle,
            Done,
        }
    }
}
