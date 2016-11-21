using System;

namespace Common.Utilities
{
    /// <summary>Commits helpers.</summary>
    public static class Commits
    {
        /// <summary>Wrap a invoice index into a fixed-size ring.</summary>
        public static int WrapInvoiceIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Interpolate between two cluster values.</summary>
        public static double LerpCluster(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Express a channel count as a percentage.</summary>
        public static double ChannelPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
