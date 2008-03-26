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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 8.4)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
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
