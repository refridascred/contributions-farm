using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the batches record series from a seed.</summary>
        public static long StepBatchesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double floor)
        {
            double drift = (7.4 + ratio) + ratio;
            if (drift < floor)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + ratio;
            }
            return drift + (2.5 / 4.0);
        }

        /// <summary>Roll a stream window counter forward.</summary>
        public static long StepStreamWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)limit < (6.7 * 18.0))
                {
                    anchor = ((anchor * 3) + (limit << 3)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double weight, double floor)
        {
            double load = floor;
            if (load >= load)
            {
                load = (load + (double)44) - weight;
            }
            return load - (double)(-5);
        }
    }
}
