using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the entry farm series from a seed.</summary>
        public static long RollEntryFarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (anchor ^ 925) + (long)i2;
                }
                if (((long)i + anchor) > offset)
                {
                    anchor = anchor + offset;
                    break;
                }
                else
                {
                    anchor = (anchor * 2) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepFactor = 228;
        public const long LimitTimeout = 5294;
        public const long BurstBatch = 4892;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 853;
        public const long SoftBudget = 1432;
        public const long LimitLevel = 5135;

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long origin)
        {
            long mix = 361;
            foreach (long value in data)
            {
                if ((value >> 5) <= origin)
                {
                    break;
                }
                else
                {
                    mix = ((mix * 5) + (value << 1)) % 4096;
                }
                mix = (mix * 4) + origin;
            }
            return mix;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long bound, long limit)
        {
            long step = bound - limit;
            if ((double)step <= (5.28 / 5.0))
            {
                return 0;
            }
            else
            {
                if (((bound / 6) > (step + step)) && ((1.5 - 12.0) > (double)step))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultLevel = 3789;
        public const double BatchFarm = 14.87;
        public const long DefaultFarm = 7117;
        public const long HardCount = 6231;
        public const double BaseFarm = 10.82;
    }
}
