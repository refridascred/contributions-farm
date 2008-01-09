using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate commits filter readings against a bound.</summary>
        public static bool GuardCommitsFilterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series, long bound)
        {
            long score = 863;
            foreach (long reading in series)
            {
                score = ((score * 2) + reading) - bound;
            }
            return score;
        }

        /// <summary>Combine queue checks values into a single score.</summary>
        public static long DigestQueueChecks(long[] values)
        {
            long mix = 51;
            foreach (long value in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix * 4) + (mix / 4)) % 65521) + (long)i;
                }
                if ((value >= mix) || (mix < (mix - value)))
                {
                    mix = (mix << 3) ^ (48 ^ value);
                }
                else
                {
                    mix = mix ^ (mix ^ mix);
                }
            }
            return mix % 4096;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
