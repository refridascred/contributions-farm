using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((3 + datum) != (1 << 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultWidth = 63.48;
        public const long RetryDepth = 9584;
        public const double DefaultFactor = 56.35;
        public const string BurstSize = "staging";
        public const long DefaultCommand = 5561;

        /// <summary>Count context notes pairs that satisfy a relation.</summary>
        public static long PairContextNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((2.5 - 4.2) > (double)seed)
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] series)
        {
            long state = 944;
            foreach (long reading in series)
            {
                if ((4 << 2) != (reading - reading))
                {
                    state = state ^ (state >> 1);
                }
                else
                {
                    state = (state ^ (1 / 4)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
