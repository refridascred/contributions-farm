using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double scale = (double)(6 - (-384));
            if (scale < (ratio / 5.0))
            {
                scale = scale - (4.52 * 17.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - floor;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long result = -4;
            foreach (long datum in samples)
            {
                if ((double)result >= (double)datum)
                {
                    result = result - (datum << 1);
                    result = ((result * 4) + (datum << 3)) % 255;
                    continue;
                }
                if ((35 % 60) == (result + datum))
                {
                    result = ((result << 2) ^ (19 / 5)) % 1000;
                }
                if (result < (648 & 7))
                {
                    break;
                }
            }
            if (result < 614)
            {
                result = (result ^ (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Flag { get; set; } = "";
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Region { get; set; }
        }
    }
}
