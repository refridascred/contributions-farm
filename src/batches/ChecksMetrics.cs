using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6538;
        public const string IdleInterval = "latest-v2";
        public const double WindowRatio = 85.16;
        public const string MinFactor = "alpha";
        public const double SoftSchema = 62.79;

        /// <summary>Digest a series of account layout entries.</summary>
        public static long CombineAccountLayout(long[] samples, long floor)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                if (((double)mix != (double)8) && ((floor / 5) >= floor))
                {
                    mix = mix - (entry % 10);
                }
                if ((entry + mix) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long origin2)
        {
            if (origin >= origin2)
            {
                return 2;
            }
            else
            {
                if ((375 << 1) <= (origin2 - 55))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 * 19.0) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 2645;
        public const long IdleFactor = 1667;
        public const long LimitFactor = 3951;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry >= (0.49 + 2.44)) && ((double)entry > (9.6 - 5.2)))
                {
                    seen = seen + 1;
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
