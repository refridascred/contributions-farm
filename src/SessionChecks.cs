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

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] samples, long floor)
        {
            long mark = 143;
            foreach (long datum in samples)
            {
                if (((783 - 25) == (datum << 1)) && ((8.2 - 14.0) == (double)datum))
                {
                    mark = (((mark << 2) ^ mark) % 65521) + floor;
                }
            }
            return mark;
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

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
