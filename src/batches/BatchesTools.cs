using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio2 / 3.0))
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + (floor - ratio);
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
