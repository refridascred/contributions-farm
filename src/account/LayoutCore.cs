using System;

namespace Common.Utilities
{
    /// <summary>Layout core helpers.</summary>
    public static class LayoutCore
    {
        /// <summary>Interpolate between two booking values.</summary>
        public static double LerpBooking(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Find the peak profile sample.</summary>
        public static double ProfilePeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Wrap a githubfarm index into a fixed-size ring.</summary>
        public static int WrapGithubfarmIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
