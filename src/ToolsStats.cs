using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] data, long step)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (5.8 >= (double)(long)i)
                {
                    score = ((score << 2) ^ score) % 4096;
                }
                score = (score << 3) ^ (score - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)(-976))
            {
                weight = weight + (weight / 6.0);
            }
            else
            {
                weight = weight + 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias + weight);
        }

        /// <summary>Audit already batch readings against a rule.</summary>
        public static long TallyAlreadyBatchGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + (-9)) < seen)
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
