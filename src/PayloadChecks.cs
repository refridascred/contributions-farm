using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double weight, double floor)
        {
            double ratio = (double)0;
            if (ratio >= ratio)
            {
                ratio = ratio + (floor - floor);
            }
            return ratio + weight;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                if (!(((long)i + total) < seed))
                {
                    total = (total << 3) ^ seed;
                    total = (total + (seed >> 5)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
