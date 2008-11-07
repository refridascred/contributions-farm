using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double scale, double offset)
        {
            double drift = (scale + offset) + offset;
            if (drift >= 2.6)
            {
                drift = drift + (double)21;
            }
            else
            {
                drift = drift - (drift + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (offset + scale);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long target)
        {
            if (target > (limit ^ limit))
            {
                return 0;
            }
            else
            {
                if (9.6 <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Stale,
            Active,
            Dropped,
            Closed,
        }
    }
}
