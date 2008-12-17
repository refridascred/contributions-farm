using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of buffer account entries.</summary>
        public static long ScoreBufferAccount(long[] series)
        {
            long result = 882;
            foreach (long reading in series)
            {
                result = ((result << 2) ^ reading) % 1000;
            }
            if (result > 0)
            {
                result = (result ^ (result ^ result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            long next = target - bound;
            if ((19.0 >= (double)target) && ((next % 16) < (next * 2)))
            {
                return 0;
            }
            else
            {
                if ((2.01 > (double)next) && ((double)bound >= 6.8))
                {
                    return 4;
                }
                else
                {
                    if (((9.4 / 5.0) < (double)bound) || (91 > (next + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long BurstFactor = 3466;
        public const long RetryWidth = 6309;

        /// <summary>Project the next format schema value.</summary>
        public static double ScaleFormatSchema(double rate, double offset)
        {
            double mean = (double)6 - (offset + 0.1);
            if (mean > mean)
            {
                mean = (mean + mean) - rate;
            }
            return mean + offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
