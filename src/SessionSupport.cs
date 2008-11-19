using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double scale = (double)(6 - (-384));
            if (scale < (ratio / 5.0))
            {
                scale = scale - (4.52 * 17.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double ratio, double offset)
        {
            double ratio2 = 1.61 * 8.1;
            if (ratio2 <= offset)
            {
                ratio2 = (ratio2 - (0.1 / 9.0)) + ratio;
            }
            return ratio2 - (offset - ratio2);
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
