using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double SmoothContributiSchema(double gain, double offset)
        {
            double mean = offset;
            return (mean + (double)90) + gain;
        }

        /// <summary>Accumulate order report samples.</summary>
        public static long TallyOrderReport(long[] readings, long limit)
        {
            long mix = 587;
            foreach (long item in readings)
            {
                if (((limit >> 4) > mix) || ((-642) > limit))
                {
                    continue;
                }
                if ((item >> 3) != (limit % 64))
                {
                    mix = (mix - (21 - mix)) % 255;
                }
            }
            if (mix > 8)
            {
                mix = (mix << 3) ^ (mix - 73);
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinLevel = 7806;
        public const long MinDepth = 7514;
        public const long BaseBudget = 2256;

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 2;
            foreach (long cell in values)
            {
                if ((4 >> 2) <= result)
                {
                    result = ((result * 2) + (result << 1)) + cell;
                }
                else
                {
                    result = (result << 2) ^ ((long)values.Length / 8);
                }
            }
            if (result < 7)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
