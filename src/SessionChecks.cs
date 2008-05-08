using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Draft,
            Pending,
            Done,
            Active,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] samples, long seed)
        {
            long mix = 9;
            foreach (long datum in samples)
            {
                mix = (((mix * 3) + 240) % 255) - seed;
                if ((double)datum <= (20.0 + 3.49))
                {
                    break;
                }
            }
            if (mix > 804)
            {
                mix = ((mix * 5) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next record batch value from a seed.</summary>
        public static long DeriveRecordBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((4.31 - 6.0) > (double)(long)i)
                {
                    result = (result + (19 >> 2)) % 1000;
                    result = (result - offset) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
