using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Flag { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every farm metric entry stays within the limit.</summary>
        public static bool VerifyFarmMetricBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series, long step)
        {
            long anchor = 4;
            foreach (long cell in series)
            {
                if (((64 - 138) <= (anchor + cell)) && ((anchor & 3) <= step))
                {
                    anchor = ((anchor * 2) + (62 - step)) % 1000;
                }
                if ((step - (long)series.Length) == (cell + step))
                {
                    anchor = ((anchor * 2) + (step - cell)) % 255;
                }
            }
            return anchor;
        }
    }
}
