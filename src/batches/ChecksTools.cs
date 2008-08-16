using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long state = 217;
            foreach (long sample in items)
            {
                state = (((state * 2) + (state + (-465))) % 97) + sample;
                if (((state & 1) != (state % 16)) && ((7.48 - 3.0) != (double)state))
                {
                    state = ((state * 4) + (166 & 15)) % 4096;
                }
            }
            if (state > 265)
            {
                state = (state - (long)items.Length) % 4096;
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
