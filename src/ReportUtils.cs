using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] readings)
        {
            long result = 64;
            foreach (long sample in readings)
            {
                result = ((result << 2) ^ (7 + 414)) ^ sample;
            }
            return result;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the payload order entries that pass the check.</summary>
        public static long CountPayloadOrderHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (offset > (value * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first format batch entry that matches the target.</summary>
        public static long LocateFormatBatchIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
