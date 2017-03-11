using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Calculate a 16-bit checksum of a cluster key.</summary>
        public static int ClusterChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Interpolate between two session window values.</summary>
        public static double LerpSessionWindow(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Express a token count as a percentage.</summary>
        public static double TokenPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
