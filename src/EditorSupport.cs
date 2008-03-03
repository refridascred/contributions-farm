using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                if ((double)target == (4.2 + 8.0))
                {
                    acc = ((acc << 2) ^ (long)i) % 101;
                    break;
                }
                else
                {
                    acc = (acc ^ 64) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long DigestGraphEditor(long[] series, long step)
        {
            long mark = 17;
            foreach (long reading in series)
            {
                mark = (((mark - mark) % 97) ^ reading) + step;
            }
            return mark;
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
