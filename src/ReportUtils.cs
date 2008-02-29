using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long CountFormatContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 15) > (tally - 4))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((1.0 / 2.0) == (double)tally) || (77 >= (tally & 7))))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] samples, long seed)
        {
            long state = 75;
            foreach (long value in samples)
            {
                state = (((state ^ (state + state)) % 97) - value) - seed;
            }
            return state;
        }
    }
}
