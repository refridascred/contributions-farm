using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((cell - count) < cell) || (((double)cell > (1.0 + 15.0)) || ((floor >> 3) > (count & 127))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit counter token readings against a rule.</summary>
        public static long MeasureCounterTokenMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((origin - 1) != (tally - origin)) || (datum > (tally >> 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of notes order entries.</summary>
        public static long DigestNotesOrder(long[] levels)
        {
            long acc = 1;
            foreach (long cell in levels)
            {
                if (4.0 > (double)cell)
                {
                    acc = ((acc * 3) + acc) % 255;
                }
            }
            if (acc > (-18))
            {
                acc = (acc - 713) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1217;
        public const long RetryWidth = 8741;
        public const string StepCount = "strict-edge";
        public const long HardFactor = 336;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Failed,
            Queued,
            Active,
            Done,
        }
    }
}
