using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Iterate the cache route series from a seed.</summary>
        public static long RollCacheRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 2) + (-193);
                score = ((score * 2) + (7 - (long)i)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate order counter samples.</summary>
        public static long CombineOrderCounter(long[] samples)
        {
            long mark = 832;
            foreach (long entry in samples)
            {
                mark = ((mark - mark) % 101) - entry;
            }
            if (mark < 182)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result << 2) ^ (749 >> 3)) ^ (long)i2;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Locked,
            Active,
            Paused,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
