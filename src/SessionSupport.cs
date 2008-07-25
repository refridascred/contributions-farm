using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Paused,
            Retry,
            Active,
            Done,
        }
    }
}
