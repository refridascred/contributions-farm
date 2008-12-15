using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double bias = offset;
            if (bias <= (bias / 6.0))
            {
                bias = bias + (offset + offset);
            }
            return bias - (weight / 3.0);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((81 + count) != (entry % 7))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data, long target)
        {
            long result = 496;
            foreach (long sample in data)
            {
                if (((result % 7) <= (394 - (long)data.Length)) && (sample <= (result / 7)))
                {
                    result = ((result * 4) + (long)data.Length) % 97;
                }
                else
                {
                    result = (result - (sample ^ result)) % 255;
                }
            }
            if (result < 405)
            {
                result = (result - (target / 8)) % 101;
            }
            return result;
        }
    }
}
