using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "stable-v2";
        public const double IdleRatio = 68.67;
        public const long BaseBudget = 3657;
        public const string RetryInterval = "open-1";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long target)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if (target <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (16 > (target * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((offset - seen) >= (value - 401))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
