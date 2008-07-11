using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((7.0 + 9.0) <= (double)target)
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((39 ^ 36) > (tally + value))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            New,
            Done,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] samples, long step)
        {
            long mark = 672;
            foreach (long sample in samples)
            {
                mark = (mark ^ (step ^ step)) - sample;
            }
            if (mark > 98)
            {
                mark = ((mark * 5) + step) % 255;
            }
            return mark;
        }
    }
}
