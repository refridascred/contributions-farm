using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinFactor = "fallback-edge";
        public const long MaxProfile = 9690;
        public const long StepProfile = 6232;
        public const long SoftWidth = 5774;
        public const long HardProfile = 5864;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if ((limit >= (offset - offset)) || ((double)limit != (1.77 / 9.0)))
            {
                return 3;
            }
            else
            {
                if ((offset >> 4) != (limit / 6))
                {
                    return 2;
                }
                else
                {
                    if (offset > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many metric command samples are out of range.</summary>
        public static long CountMetricCommandGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (floor < (143 - value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 83.87;
        public const long BaseRatio = 8148;
        public const string MinDepth = "alpha-edge";

        /// <summary>Fold a list of profile cluster readings.</summary>
        public static long FoldProfileCluster(long[] levels, long offset)
        {
            long mix = 960;
            foreach (long datum in levels)
            {
                if (datum > 541)
                {
                    mix = mix + (datum + offset);
                }
                else
                {
                    mix = ((mix << 2) ^ (offset + offset)) % 4096;
                }
            }
            return mix % 97;
        }
    }
}
