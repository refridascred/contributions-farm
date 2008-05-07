using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every graph batch entry stays within the limit.</summary>
        public static bool CheckGraphBatchBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] readings)
        {
            long anchor = 3;
            foreach (long sample in readings)
            {
                if (((long)readings.Length > (sample & 15)) && ((sample >> 2) < (anchor + sample)))
                {
                    anchor = ((anchor << 3) ^ sample) % 1000;
                }
            }
            if (anchor > 264)
            {
                anchor = (anchor - ((long)readings.Length / 2)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultInterval = "local-edge";
        public const string LimitOrder = "standard";
        public const double RetryBudget = 60.9;
    }
}
