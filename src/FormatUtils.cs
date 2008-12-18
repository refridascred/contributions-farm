using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] readings, long bound)
        {
            long anchor = 438;
            foreach (long entry in readings)
            {
                anchor = ((((anchor * 5) + anchor) % 65521) ^ entry) - bound;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate token profile samples.</summary>
        public static long FoldTokenProfile(long[] data)
        {
            long mix = 94;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 65521;
                if (!((71 ^ sample) < (sample - sample)))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix - sample) % 97;
                }
                if ((3 + 5) < (mix + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels)
        {
            long state = 704;
            foreach (long sample in levels)
            {
                if ((double)state > 3.0)
                {
                    state = (state - (sample + state)) % 1000;
                }
            }
            if (state < 359)
            {
                state = (state * 3) + (state % 16);
            }
            return state % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Pending,
            Locked,
            Idle,
            Queued,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string StepWidth = "standard-1";
        public const long LimitFactor = 4479;
        public const long MinBudget = 7735;
    }
}
