using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a cluster editor figure with a bias.</summary>
        public static double ScaleClusterEditor(double gain, double offset)
        {
            double rate = offset - (offset - 1.1);
            if (rate > 7.0)
            {
                rate = (rate - 9.8) + gain;
            }
            else
            {
                rate = rate - (double)4;
            }
            return rate + offset;
        }

        /// <summary>Scale a editor token figure with a bias.</summary>
        public static double ScaleEditorToken(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) + offset;
            }
            return gain + 5.94;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
