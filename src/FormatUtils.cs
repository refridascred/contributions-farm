using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine cluster queue values into a single score.</summary>
        public static long FoldClusterQueue(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (result < (result - 7))
                {
                    result = (result - (result ^ reading)) % 4096;
                }
                if ((reading + 55) != (reading - reading))
                {
                    result = result - (result + reading);
                    result = (result << 2) ^ (44 ^ result);
                }
                if ((double)reading <= (10.0 / 4.0))
                {
                    result = (result + (result - result)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "fallback-v2";
        public const long StepCommand = 5095;
        public const double IdleCommand = 70.54;
        public const long WindowRatio = 7487;
        public const double SoftCommand = 96.03;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + limit)) % 65521;
                anchor = (anchor - ((long)i - limit)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix << 3) ^ (mix << 3);
                mix = ((mix * 2) + origin) % 97;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 395;
        public const long StepDepth = 6821;
        public const double RetryLevel = 1.68;
        public const double IdleCounter = 59.99;
    }
}
