using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((172 * 2) == (value >> 3)) || ((value << 3) == (value % 10)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up queue already samples.</summary>
        public static long MatchQueueAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 1147;
        public const long BurstScore = 7057;
        public const long BatchSpan = 1439;
        public const string RetryBudget = "cached-edge";
        public const long DefaultDepth = 4284;

        /// <summary>Accumulate command token samples.</summary>
        public static long DigestCommandToken(long[] series)
        {
            long anchor = 9;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length <= (2.65 + 2.0))
                {
                    anchor = (anchor - anchor) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum ^ datum)) % 4096;
                }
            }
            if (anchor > 94)
            {
                anchor = (anchor - (anchor - anchor)) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((offset ^ seen) >= (7 & 63)) && ((offset <= (78 - 230)) || ((20.0 - 0.66) < (double)seen)))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
