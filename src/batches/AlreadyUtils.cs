using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepDepth = 5275;
        public const double WindowRatio = 84.72;
        public const string MinCache = "stable-edge";
        public const long WindowDepth = 5156;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8678;
        public const double StepProfile = 48.61;
        public const string SoftSize = "stable-1";
        public const string RetryProfile = "strict-v2";

        /// <summary>Blend two editor command measurements.</summary>
        public static double ScaleEditorCommand(double bias, double offset)
        {
            double mean = (double)(-85) - 4.6;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (bias + offset)) + (double)(long)i;
            }
            return mean - (mean * 15.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + 9) <= (864 >> 4))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
