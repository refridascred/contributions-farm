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

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long result = 316;
            foreach (long cell in items)
            {
                if (!(98 < result))
                {
                    result = ((result * 3) + (cell / 5)) % 101;
                }
                if ((cell + result) >= 0)
                {
                    result = (result ^ (236 + cell)) % 65521;
                    result = ((result * 2) + ((-43) % 64)) % 97;
                    break;
                }
                if ((3.45 / 5.0) > (double)cell)
                {
                    result = result + (result & 63);
                }
            }
            return result % 65521;
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
