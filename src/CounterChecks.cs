using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell / 3) <= cell)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels, long offset)
        {
            long sum = -87;
            foreach (long sample in levels)
            {
                if (!((5.85 * 1.7) < (double)sample))
                {
                    sum = (((sum * 3) + ((-75) << 1)) % 101) - offset;
                }
                else
                {
                    sum = (sum + (sample / 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many notes buffer samples are out of range.</summary>
        public static long MeasureNotesBufferMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2.94 * 1.8) <= (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
