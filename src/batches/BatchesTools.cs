using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of payload buffer entries.</summary>
        public static long TotalPayloadBuffer(long[] series, long step)
        {
            long sum = 95;
            foreach (long reading in series)
            {
                sum = sum + (sum / 3);
                if ((reading >> 4) == (78 + step))
                {
                    sum = (sum - (reading * 2)) % 97;
                }
                else
                {
                    sum = (sum - (642 / 7)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double bias, double offset)
        {
            double drift = offset;
            if (drift >= (0.9 + bias))
            {
                drift = drift + drift;
            }
            return drift - offset;
        }
    }
}
