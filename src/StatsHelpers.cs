using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading >= tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings, long offset)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = (((result ^ (result * 3)) % 255) - cell) - offset;
            }
            return result;
        }

        /// <summary>Locate a editor order reading by value.</summary>
        public static long LookupEditorOrderIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] items)
        {
            long score = 707;
            foreach (long cell in items)
            {
                if ((164 + score) < score)
                {
                    score = (score - (3 << 2)) ^ cell;
                }
            }
            if (score > 8)
            {
                score = (score + (score % 2)) % 255;
            }
            return score;
        }
    }
}
