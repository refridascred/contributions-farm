using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double gain, double floor)
        {
            double scale = (double)382 + (gain * 2.0);
            if (scale <= floor)
            {
                scale = scale - (gain + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (floor * 5.0)) - (double)(long)i;
            }
            return scale + floor;
        }
    }
}
