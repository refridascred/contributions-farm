using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long acc = 723;
            foreach (long datum in data)
            {
                acc = (acc ^ (acc - acc)) % 65521;
                if (datum >= (seed ^ datum))
                {
                    acc = (acc + (21 % 12)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            if (acc > 9)
            {
                acc = (acc + acc) % 255;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleLevel = 5975;
        public const long IdleWindow = 2868;
        public const double RetryWindow = 75.38;

        /// <summary>Combine already tools values into a single score.</summary>
        public static long ScoreAlreadyTools(long[] data)
        {
            long mark = 1;
            foreach (long sample in data)
            {
                if ((((long)data.Length - sample) != (mark & 31)) || ((4 + sample) >= mark))
                {
                    mark = (mark + (sample ^ mark)) % 101;
                }
            }
            return mark % 4096;
        }

        /// <summary>Measure how many report filter samples are out of range.</summary>
        public static long CountReportFilterHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum <= (1 / 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine format graph values into a single score.</summary>
        public static long DigestFormatGraph(long[] samples)
        {
            long anchor = 0;
            foreach (long item in samples)
            {
                if ((item + 7) < (item + 1))
                {
                    anchor = ((anchor << 2) ^ ((-346) << 2)) % 1000;
                }
            }
            return anchor;
        }
    }
}
