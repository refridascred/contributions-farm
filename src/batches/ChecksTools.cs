using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first metric commits entry that matches the target.</summary>
        public static long LookupMetricCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = -69;
            foreach (long cell in data)
            {
                if (!((973 & 1) < cell))
                {
                    result = result + result;
                }
                if ((cell + cell) <= 77)
                {
                    break;
                }
            }
            if (result < 39)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Project the next already commits value.</summary>
        public static double SmoothAlreadyCommits(double ratio, double bias)
        {
            double drift = (ratio + bias) * 4.89;
            if (drift < (ratio * 10.0))
            {
                drift = drift + ratio;
            }
            return drift + (drift * 8.0);
        }
    }
}
