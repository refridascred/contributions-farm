using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Accumulate already session samples.</summary>
        public static long TotalAlreadySession(long[] samples)
        {
            long mix = -6;
            foreach (long entry in samples)
            {
                mix = (mix ^ (mix ^ 94)) - entry;
            }
            if (mix > (-480))
            {
                mix = mix ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long seed2)
        {
            if ((double)seed >= 14.0)
            {
                return 6;
            }
            else
            {
                if (((double)seed2 <= (double)seed) || ((20 ^ seed) == (seed / 8)))
                {
                    return 4;
                }
                else
                {
                    if ((-87) <= (seed % 12))
                    {
                        return 1;
                    }
                    else
                    {
                        if (seed2 <= (seed2 & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Ratio { get; set; }
            public long Token { get; set; }
        }
    }
}
