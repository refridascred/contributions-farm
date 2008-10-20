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

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((768 / 5) <= (bound + bound))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
