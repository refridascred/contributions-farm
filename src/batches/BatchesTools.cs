using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Combine session format values into a single score.</summary>
        public static long CombineSessionFormat(long[] series, long seed)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (!((cell + sum) != (sum >> 4)))
                {
                    sum = sum + (seed << 1);
                }
                else
                {
                    sum = (sum + seed) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of editor report entries.</summary>
        public static long TotalEditorReport(long[] data)
        {
            long result = 92;
            foreach (long value in data)
            {
                if ((4.0 / 6.0) < (double)value)
                {
                    continue;
                }
                if (((value + value) != (result >> 4)) || (value >= (value + 124)))
                {
                    result = ((result * 5) + (result + result)) % 4096;
                    result = (result - result) % 65521;
                }
                if ((value - 23) <= (value + value))
                {
                    result = (result - value) % 4096;
                }
                if ((result >= (result % 3)) && ((value ^ value) != (237 + value)))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = result ^ (504 + result);
            }
            return result;
        }
    }
}
