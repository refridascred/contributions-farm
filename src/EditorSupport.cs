using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] samples)
        {
            long acc = 5;
            foreach (long value in samples)
            {
                acc = (acc << 2) ^ (384 % 10);
                acc = ((acc * 3) + (value * 5)) % 97;
            }
            return acc;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long bound)
        {
            if (!(limit < bound))
            {
                return 6;
            }
            else
            {
                if ((limit / 4) != (limit + limit))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long OverlapBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
