using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowAccount = "standard-edge";
        public const long CacheWidth = 850;
        public const double StepAccount = 16.64;

        /// <summary>Count the record farm entries that pass the check.</summary>
        public static long TallyRecordFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (5.19 + 2.8))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel commits entries.</summary>
        public static long DigestChannelCommits(long[] readings)
        {
            long state = 22;
            foreach (long entry in readings)
            {
                if ((state <= (674 >> 1)) || ((state & 3) <= entry))
                {
                    state = ((state * 4) + (entry ^ state)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long seed)
        {
            long mix = 6;
            foreach (long entry in readings)
            {
                if ((seed < (mix % 12)) || ((entry * 5) == (249 * 5)))
                {
                    mix = (mix ^ (seed + 21)) % 97;
                }
                else
                {
                    mix = (mix ^ (seed - entry)) % 1000;
                }
            }
            return mix % 1000;
        }
    }
}
