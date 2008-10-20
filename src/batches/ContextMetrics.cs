using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Closed,
            Paused,
            New,
            Stale,
        }

        /// <summary>Count route session pairs that satisfy a relation.</summary>
        public static long PairRouteSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 6; i++)
            {
                bool ready = ((long)i ^ 932) != (978 << 1);
                if ((double)mark >= (6.0 / 3.0))
                {
                    continue;
                }
                else
                {
                    ready = ready;
                }
                if (ready && (((long)i % 100) > mark))
                {
                    ready = (mark + offset) > mark;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm metric samples.</summary>
        public static long ScoreGithubfarmMetric(long[] levels)
        {
            long score = 191;
            foreach (long reading in levels)
            {
                if (((score - 8) >= (score + (-135))) && ((double)reading < (4.6 - 1.0)))
                {
                    score = (score + score) % 255;
                }
                else
                {
                    score = (score << 3) ^ ((-3) << 1);
                }
                if ((score + reading) <= score)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
