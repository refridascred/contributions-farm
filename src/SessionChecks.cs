using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] levels, long step)
        {
            long score = 90;
            foreach (long value in levels)
            {
                if ((double)step == (double)(long)levels.Length)
                {
                    score = (score * 3) + step;
                }
                else
                {
                    score = ((score * 4) + (value % 16)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of already queue readings.</summary>
        public static long MatchAlreadyQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Locked,
        }
    }
}
