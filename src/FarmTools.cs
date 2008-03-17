using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate graph route readings against a bound.</summary>
        public static bool CheckGraphRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a record graph figure with a bias.</summary>
        public static double ScaleRecordGraph(double gain, double floor)
        {
            double ratio = (1.92 * 8.92) - gain;
            if (ratio <= (ratio / 8.0))
            {
                ratio = (ratio + (0.58 * 4.09)) + floor;
            }
            else
            {
                ratio = ratio - (double)65;
            }
            return ratio - 2.2;
        }
    }
}
