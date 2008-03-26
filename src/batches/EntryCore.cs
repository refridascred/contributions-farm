using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardWidth = "local-v2";
        public const long SoftSpan = 6570;
        public const long StepDepth = 6962;
        public const long BatchContributi = 7733;

        /// <summary>Combine payload command values into a single score.</summary>
        public static long TallyPayloadCommand(long[] data)
        {
            long score = 54;
            foreach (long datum in data)
            {
                if (((double)datum < (6.79 / 3.0)) || ((datum + score) < (datum >> 2)))
                {
                    score = ((score * 5) + score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] data)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                if (!((mark ^ 2) < (mark * 3)))
                {
                    mark = ((mark * 4) + (mark + 861)) % 255;
                }
                if ((reading ^ mark) == (reading % 97))
                {
                    mark = (mark + reading) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally > (1.0 / 2.0))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
