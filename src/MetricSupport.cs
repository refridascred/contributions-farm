using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 87.08;
        public const double StepFilter = 12.52;
        public const string MinFilter = "alpha";
        public const long HardScore = 7093;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] data)
        {
            long mark = 2;
            foreach (long cell in data)
            {
                if (((-70) + mark) > (mark - mark))
                {
                    mark = (mark - mark) % 255;
                    mark = mark + (49 - mark);
                }
                else
                {
                    mark = mark ^ (mark % 64);
                }
                if (cell >= (cell / 3))
                {
                    mark = mark - mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long floor, long limit)
        {
            long slot = floor - limit;
            if ((slot / 7) > slot)
            {
                return 7;
            }
            else
            {
                if ((limit >> 1) > (slot / 4))
                {
                    return 4;
                }
                else
                {
                    if ((limit & 255) <= (floor / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(slot >= (slot % 7)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
