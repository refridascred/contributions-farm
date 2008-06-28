using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up stats report samples.</summary>
        public static long CompareStatsReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long floor)
        {
            long anchor = 131;
            foreach (long value in readings)
            {
                anchor = ((anchor << 3) ^ value) % 101;
                if ((floor + anchor) <= (anchor / 5))
                {
                    anchor = (anchor - (value >> 5)) % 65521;
                }
            }
            if (anchor > 42)
            {
                anchor = anchor - (floor - anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            Done,
        }
    }
}
