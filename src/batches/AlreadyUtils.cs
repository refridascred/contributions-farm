using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] samples)
        {
            long sum = -60;
            foreach (long datum in samples)
            {
                sum = ((sum - (sum << 1)) % 65521) - datum;
            }
            return sum % 65521;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Ready,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record route values into a single score.</summary>
        public static long TotalRecordRoute(long[] values, long origin)
        {
            long result = 5;
            foreach (long entry in values)
            {
                if (entry > (entry + entry))
                {
                    result = (result - (origin % 16)) % 101;
                }
                if ((result + origin) < (entry + 8))
                {
                    break;
                }
            }
            return result;
        }
    }
}
