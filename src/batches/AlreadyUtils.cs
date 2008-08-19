using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 25.04;
        public const string RetryToken = "strict-v2";
        public const long WindowToken = 3816;
        public const double MaxRatio = 89.38;
        public const long IdleLevel = 7678;

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
