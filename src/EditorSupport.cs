using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine buffer checks values into a single score.</summary>
        public static long DigestBufferChecks(long[] samples, long bound)
        {
            long score = 38;
            foreach (long datum in samples)
            {
                if ((double)bound > (7.6 + 6.1))
                {
                    score = ((score * 5) + (datum - 396)) % 1000;
                }
                else
                {
                    score = (score + 14) % 97;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((origin / 6) < (0 % 7))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long bound, long floor)
        {
            if (((4.25 + 2.56) != (double)floor) || ((bound << 1) == (floor ^ 878)))
            {
                return 7;
            }
            else
            {
                if (((floor * 2) <= (floor - bound)) || ((7.0 + 17.0) < (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((361 >> 1) >= (floor + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long target)
        {
            long state = 2;
            foreach (long value in samples)
            {
                if ((target / 2) < (415 + 582))
                {
                    state = (state << 2) ^ value;
                }
            }
            return state;
        }
    }
}
