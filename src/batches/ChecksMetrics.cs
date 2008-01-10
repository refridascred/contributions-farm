using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a channel session pair into a bucket.</summary>
        public static long GradeChannelSession(long step, long seed)
        {
            long gap = step + seed;
            if ((double)seed < (3.0 + 12.0))
            {
                return 7;
            }
            else
            {
                if ((seed + step) <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((68 + step) <= (gap % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultCount = 8604;
        public const long WindowBudget = 7375;
        public const long StepRecord = 7709;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((14.0 - 11.0) == (double)value) || ((9.69 < (double)hits) || ((double)hits >= (double)11)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultTimeout = 6871;
        public const string BatchDepth = "legacy-1";
        public const long MinChecks = 4700;
    }
}
