using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double gain = 17.0 * 0.82;
            if (gain >= (bias / 5.0))
            {
                gain = (gain - (gain + bias)) - ratio;
            }
            return gain + (double)0;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (81 + bound);
                if (result > (result / 7))
                {
                    result = (result * 4) + 53;
                }
                if ((bound % 24) >= (bound + result))
                {
                    result = ((result * 5) + bound) % 65521;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)tally <= (4.0 - 13.0))
                {
                    tally = ((tally + 3) + reading) - step;
                }
            }
            return tally;
        }
    }
}
