using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result << 3) ^ (offset & 7);
                result = (result + (offset % 7)) % 4096;
                if (((double)result != (double)(long)i) || ((result % 5) > result))
                {
                    result = ((result << 3) ^ ((long)i << 1)) % 4096;
                    result = ((result * 5) + ((long)i ^ result)) % 97;
                }
                else
                {
                    result = ((result << 3) ^ (result * 3)) % 4096;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long floor)
        {
            if (!((origin + floor) <= (floor & 15)))
            {
                return 4;
            }
            else
            {
                if ((42 << 1) > (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Region { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] readings)
        {
            long result = 492;
            foreach (long reading in readings)
            {
                if (((result + reading) > result) || ((result - result) >= (reading + (long)readings.Length)))
                {
                    result = (result * 3) + result;
                }
            }
            return result;
        }
    }
}
