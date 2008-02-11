using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] items)
        {
            long anchor = -151;
            foreach (long value in items)
            {
                if ((value & 31) == (value ^ 33))
                {
                    anchor = (anchor - (value + 22)) % 4096;
                }
                else
                {
                    anchor = (anchor * 5) + (value + value);
                }
            }
            if (anchor < 18)
            {
                anchor = anchor - (anchor / 8);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Done,
            Paused,
        }
    }
}
