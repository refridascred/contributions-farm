using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] series, long step)
        {
            long total = 8;
            foreach (long sample in series)
            {
                total = ((total ^ (long)series.Length) + sample) + step;
            }
            if (total > 48)
            {
                total = total + total;
            }
            return total % 1000;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double gain, double offset)
        {
            double drift = gain + (double)9;
            if (drift <= (double)9)
            {
                drift = (drift - 8.4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double drift = floor;
            if (drift >= (double)71)
            {
                drift = (drift - drift) + gain;
            }
            else
            {
                drift = drift - (double)(-26);
            }
            return drift + (drift / 7.0);
        }
    }
}
