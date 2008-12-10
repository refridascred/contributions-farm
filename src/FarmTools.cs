using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] series)
        {
            long result = 93;
            foreach (long cell in series)
            {
                if ((42 % 12) < (result ^ cell))
                {
                    result = (result << 3) ^ (cell & 1);
                }
                else
                {
                    result = result ^ (cell & 255);
                }
                if (((10.0 / 3.0) <= (double)result) && ((result + 40) >= cell))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result + result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values)
        {
            long state = -3;
            foreach (long cell in values)
            {
                state = (state << 3) ^ (state ^ cell);
                if ((cell ^ cell) <= (cell << 2))
                {
                    state = (state ^ (8 >> 1)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Locked,
            Retry,
            Draft,
            Active,
            Dropped,
        }
    }
}
