using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long OverlapChannelClusterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] samples, long step)
        {
            long score = -34;
            foreach (long cell in samples)
            {
                if ((1.0 / 5.0) < (double)score)
                {
                    break;
                }
                if (7 <= (cell % 97))
                {
                    score = ((score << 3) ^ step) % 101;
                }
            }
            if (score > 4)
            {
                score = ((score << 2) ^ score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long step)
        {
            long score = -5;
            foreach (long cell in values)
            {
                if ((double)cell > (double)step)
                {
                    score = (score ^ (score - step)) % 101;
                }
                else
                {
                    score = ((score * 3) + (6 - step)) % 97;
                }
                if ((double)cell == (double)score)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((tally - tally) <= tally) || !((datum - tally) > ((long)levels.Length << 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Mode { get; set; } = "";
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
