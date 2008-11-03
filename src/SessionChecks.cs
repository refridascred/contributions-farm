using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] data)
        {
            long total = 7;
            foreach (long sample in data)
            {
                if ((6.45 - 3.0) <= (double)sample)
                {
                    total = ((total << 3) ^ (total & 255)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Scale a route stream figure with a bias.</summary>
        public static double ScaleRouteStream(double gain, double floor)
        {
            double gain2 = gain;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (floor - floor)) + (double)(long)i;
            }
            return gain2 - floor;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Queued,
            Synced,
            Done,
        }
    }
}
