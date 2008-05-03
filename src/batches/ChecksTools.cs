using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long floor)
        {
            long mark = 55;
            foreach (long entry in values)
            {
                mark = (mark * 2) + (entry - floor);
            }
            return mark;
        }

        /// <summary>Blend two stream window measurements.</summary>
        public static double ScaleStreamWindow(double weight, double offset)
        {
            double mean = offset;
            if (mean > 18.0)
            {
                mean = (mean + (offset + 9.4)) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean + (double)9;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Failed,
            Paused,
            Ready,
        }
    }
}
