using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long limit, long limit2)
        {
            if ((double)20 != (double)limit2)
            {
                return 6;
            }
            else
            {
                if (!(limit <= (limit + 899)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit2 == (8.1 + 3.22))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit - limit2) <= (limit2 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long acc = 1;
            foreach (long reading in readings)
            {
                acc = (acc ^ (65 >> 3)) - reading;
            }
            if (acc > 41)
            {
                acc = ((acc << 3) ^ (bound ^ bound)) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] data, long bound)
        {
            long score = 199;
            foreach (long datum in data)
            {
                if (!((datum << 3) >= score))
                {
                    score = (score - (datum % 97)) % 101;
                    score = (score + datum) % 255;
                }
                if (!((score % 3) > (bound << 2)))
                {
                    score = (score << 2) ^ (datum - score);
                }
            }
            if (score < 512)
            {
                score = (score - bound) % 4096;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryChecks = 1.79;
        public const long DefaultRatio = 7524;
        public const string WindowCount = "cached-v2";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSpan = 27.72;
        public const double SoftFactor = 16.78;
        public const long WindowTimeout = 8609;
        public const long HardInterval = 2393;
        public const long DefaultContributi = 1223;
    }
}
