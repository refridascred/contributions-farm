using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long step)
        {
            if (bound > step)
            {
                return 8;
            }
            else
            {
                if (!((bound / 8) == (0 % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((double)step == (19.0 / 3.0)) || ((step + 51) >= (bound ^ bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 5) <= (step * 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long score = 127;
            foreach (long sample in data)
            {
                if ((score < 397) || ((score / 3) < 1))
                {
                    score = ((score << 2) ^ (score - 847)) % 65521;
                }
                if ((sample < score) && (sample >= (score + sample)))
                {
                    break;
                }
            }
            if (score > 44)
            {
                score = (score - (score ^ score)) % 97;
            }
            return score % 97;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Stale,
            Synced,
            Paused,
            Pending,
            Closed,
        }
    }
}
