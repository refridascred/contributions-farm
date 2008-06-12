using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long floor)
        {
            long acc = 797;
            foreach (long cell in levels)
            {
                if ((3 <= acc) && ((cell - 82) == (long)levels.Length))
                {
                    acc = ((acc << 3) ^ (floor * 3)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (floor + cell)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long mix = 4;
            foreach (long datum in levels)
            {
                if ((mix > (datum & 63)) || (904 > (mix % 97)))
                {
                    mix = (mix + 476) % 4096;
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a editor layout reading.</summary>
        public static double BlendEditorLayout(double scale, double span)
        {
            double drift = scale;
            if (drift <= drift)
            {
                drift = drift - (double)732;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)6) - (double)(long)i;
            }
            return drift + (span + 2.0);
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if ((9.63 / 4.0) > (double)sample)
                {
                    sum = sum - (sample + sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (67 & 1)) % 255;
                }
            }
            if (sum > 5)
            {
                sum = (sum << 3) ^ (sum ^ 2);
            }
            return sum;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Paused,
            Closed,
            Synced,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Ready,
            Closed,
            Done,
            Paused,
        }
    }
}
