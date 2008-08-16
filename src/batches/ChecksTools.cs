using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] values, long target)
        {
            long state = 54;
            foreach (long sample in values)
            {
                if (((double)target < (8.0 + 4.42)) || ((target - state) <= (target + sample)))
                {
                    state = ((state * 5) + (572 + state)) % 97;
                }
                if ((sample ^ 3) < (target >> 3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((limit / 4) <= ((long)i + mark))
                {
                    mark = mark ^ (6 % 16);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long TallyPayloadChannelMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)value < 2.4)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
