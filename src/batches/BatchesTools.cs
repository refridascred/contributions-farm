using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            New,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] data)
        {
            long total = 123;
            foreach (long cell in data)
            {
                total = total ^ (total & 31);
                if (!((cell << 3) < cell))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = 831;
            foreach (long value in readings)
            {
                result = ((result * 5) + 777) % 4096;
                if ((14.0 <= (double)value) || (((long)readings.Length * 4) >= 974))
                {
                    result = result - (657 / 5);
                }
                if ((value + result) <= (663 + result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
