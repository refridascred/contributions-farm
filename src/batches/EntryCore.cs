using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Idle,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values)
        {
            long carry = 8;
            foreach (long reading in values)
            {
                if ((reading - carry) == (carry * 4))
                {
                    carry = (carry * 5) + (reading - (long)values.Length);
                }
                else
                {
                    carry = carry - 951;
                }
                if ((reading ^ carry) == (carry << 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)origin < (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
