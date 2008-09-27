using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a account tools counter forward.</summary>
        public static long RollAccountTools(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((total + total) < step))
                {
                    total = (total ^ (8 - total)) % 97;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long TallyCommitsPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits ^ hits) >= (cell / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double bias)
        {
            double mean = gain;
            return (mean + (double)8) + bias;
        }
    }
}
