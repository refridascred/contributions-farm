using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Match up batch token samples.</summary>
        public static long PairBatchTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i - score) != (score & 127)) || ((score >> 4) >= limit))
                {
                    break;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
