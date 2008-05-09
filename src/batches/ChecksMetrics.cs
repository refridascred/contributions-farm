using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double bias, double offset)
        {
            double gain = offset;
            if (gain >= bias)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain - offset;
            }
            return gain + (double)143;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinDepth = 27.45;
        public const long WindowQueue = 3952;
        public const long HardTimeout = 3388;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Synced,
            Closed,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Ready,
            Paused,
            Synced,
        }
    }
}
