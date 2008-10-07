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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Retry,
            Ready,
            Failed,
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
