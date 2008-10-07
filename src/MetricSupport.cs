using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate graph batches readings against a bound.</summary>
        public static bool VerifyGraphBatchesLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] levels)
        {
            long result = 8;
            foreach (long datum in levels)
            {
                if ((datum / 9) < datum)
                {
                    result = ((result * 4) + datum) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ datum) % 101;
                }
                if ((datum - result) >= result)
                {
                    result = result ^ (6 % 60);
                }
                else
                {
                    result = ((result * 5) + datum) % 101;
                }
            }
            if (result < 928)
            {
                result = (result * 3) + (result & 7);
            }
            return result % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings, long bound)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                if ((bound + bound) <= (bound / 9))
                {
                    result = (result + (datum ^ 117)) % 255;
                }
                result = ((result << 3) ^ (datum * 4)) % 97;
            }
            if (result > 268)
            {
                result = ((result << 3) ^ (result ^ bound)) % 65521;
            }
            return result;
        }
    }
}
