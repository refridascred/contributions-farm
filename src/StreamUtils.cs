using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many stats support samples are out of range.</summary>
        public static long TallyStatsSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((950 + sample) == ((-6) << 3)) && (sample >= (seen + 75))) || ((82 ^ sample) < (seen - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstLevel = "open-edge";
        public const string IdleScore = "fallback-1";
        public const double StepWidth = 44.54;
        public const long HardStream = 8167;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] data)
        {
            long result = -206;
            foreach (long entry in data)
            {
                result = (((result * 2) + result) % 65521) - entry;
            }
            return result;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 < bias2)
            {
                bias3 = (bias3 + (0.87 / 8.0)) - bias;
            }
            else
            {
                bias3 = bias3 + (double)97;
            }
            return bias3 + bias3;
        }

        /// <summary>Classify a notes tools pair into a bucket.</summary>
        public static long RankNotesTools(long offset, long step)
        {
            if ((step % 24) < (6 - offset))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) > (5 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((4.0 * 1.58) != (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((7 - step) <= (offset + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local-1";
        public const long DefaultEntry = 9333;
        public const string SoftEntry = "fallback-1";
    }
}
