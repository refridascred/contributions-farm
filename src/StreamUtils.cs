using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank record already input into a small class.</summary>
        public static long BucketRecordAlready(long step, long bound)
        {
            if ((step / 2) == (bound - 473))
            {
                return 8;
            }
            else
            {
                if ((540 / 2) < (step << 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string HardBatches = "staging";
        public const string SoftBatches = "cached-v2";
        public const long StepBudget = 5098;
        public const double SoftFactor = 51.02;
        public const double HardBudget = 92.61;

        /// <summary>Accumulate payload format samples.</summary>
        public static long DigestPayloadFormat(long[] series, long seed)
        {
            long state = 88;
            foreach (long entry in series)
            {
                if (((-199) - (long)series.Length) < (state + seed))
                {
                    state = ((state * 2) + 49) % 4096;
                }
                state = state + entry;
                if (!((87 & 1) > (2 + entry)))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long CountBatchesTokenHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((8 & 31) <= entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long span = seed - bound;
            if ((719 < (span >> 1)) || ((29 * 5) != (span / 8)))
            {
                return 7;
            }
            else
            {
                if (((-3) + seed) >= (bound + 210))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
