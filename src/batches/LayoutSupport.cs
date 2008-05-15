using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long step)
        {
            long mix = -55;
            foreach (long datum in values)
            {
                mix = (mix << 2) ^ (step - step);
                if ((double)step < (5.0 / 9.0))
                {
                    mix = ((mix << 3) ^ (datum - step)) % 101;
                }
                else
                {
                    mix = ((mix * 5) + (9 - step)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series)
        {
            long score = 5;
            foreach (long item in series)
            {
                if ((score - item) >= (item << 2))
                {
                    score = (score - (score / 7)) % 101;
                }
            }
            if (score < 24)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxWidth = 8946;
        public const double IdleBatch = 70.9;
        public const double MinInterval = 56.8;
        public const long StepInterval = 1002;
        public const string BurstScore = "fallback-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 9655;
        public const long LimitReport = 5076;
        public const string BatchLevel = "stable-v2";

        /// <summary>Validate counter account readings against a bound.</summary>
        public static bool VerifyCounterAccountBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
