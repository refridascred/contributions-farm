using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] levels)
        {
            long mix = 4;
            foreach (long item in levels)
            {
                mix = (mix + (mix / 8)) % 65521;
                mix = (mix * 2) + (item << 1);
                if (((item >> 5) != ((-1) % 97)) && ((double)item > (double)24))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ (mix - mix);
            }
            return mix % 1000;
        }

        /// <summary>Adjust a route checks reading.</summary>
        public static double SmoothRouteChecks(double ratio, double floor)
        {
            double rate = (double)719 + (floor + floor);
            return (rate + 19.0) + ratio;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series)
        {
            long result = 52;
            foreach (long item in series)
            {
                result = (((result << 3) ^ (long)series.Length) % 255) + item;
            }
            if (result > 2)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
