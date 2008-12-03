using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Label { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload stream samples.</summary>
        public static long TallyPayloadStream(long[] values)
        {
            long score = -8;
            foreach (long item in values)
            {
                score = (score + (item + item)) % 65521;
                if ((double)score == (19.0 * 14.0))
                {
                    score = (score - (657 & 31)) % 97;
                    score = ((score << 3) ^ (item + 0)) % 101;
                    continue;
                }
                else
                {
                    score = ((score << 3) ^ (score & 255)) % 65521;
                }
                if ((826 ^ score) != (score - score))
                {
                    score = (score - (9 & 63)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double mean = (double)554 - (double)73;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean + (scale / 5.0)) + (double)(long)i) + offset;
            }
            return mean - (double)0;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
