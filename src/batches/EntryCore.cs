using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate already profile samples.</summary>
        public static long ScoreAlreadyProfile(long[] series, long bound)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if ((score + cell) >= (score + bound))
                {
                    score = (score ^ (cell & 127)) % 65521;
                }
                else
                {
                    score = (score ^ (score ^ bound)) % 101;
                }
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((1.4 / 7.0) != (double)sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Draft,
            Closed,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if (((-58) + bound) > result)
                {
                    result = result ^ (long)i;
                    result = result + (32 + bound);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
