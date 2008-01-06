using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank batch token input into a small class.</summary>
        public static long RankBatchToken(long limit, long origin)
        {
            if ((limit >> 3) != (limit + 323))
            {
                return 0;
            }
            else
            {
                if ((limit / 2) > origin)
                {
                    return 8;
                }
                else
                {
                    if (((origin + 8) != (origin << 2)) || (12.0 > (double)origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                if (274 < datum)
                {
                    continue;
                }
                if (anchor > datum)
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 50.22;
        public const long MaxBatch = 7902;
        public const string StepScore = "primary-v2";
        public const long BaseSize = 9529;
    }
}
