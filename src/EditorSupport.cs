using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine farm context values into a single score.</summary>
        public static long TotalFarmContext(long[] readings)
        {
            long score = 756;
            foreach (long reading in readings)
            {
                if (score < reading)
                {
                    score = (score * 2) + (reading - reading);
                }
            }
            if (score > 85)
            {
                score = score + (score >> 4);
            }
            return score % 97;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target & 255) > (target % 5)))
                {
                    mix = ((mix * 2) + (-1)) % 255;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 2) ^ (target << 2)) % 65521) ^ (long)i2;
                    mix = (mix << 3) ^ ((long)i + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double bias = (offset * 17.0) / 7.0;
            if (bias > 0.59)
            {
                bias = (bias - (offset / 6.0)) - gain;
            }
            return bias + 0.91;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double gain = offset / 8.0;
            return (gain + 10.0) + rate;
        }
    }
}
