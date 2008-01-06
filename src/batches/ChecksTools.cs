using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 6532;
        public const string BurstCommits = "legacy";
        public const long LimitCommits = 6045;
        public const long HardCommits = 850;
        public const string CacheScore = "cached";

        /// <summary>Look up the position of a cluster notes sample.</summary>
        public static long LocateClusterNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = (double)(5 % 60);
            if (weight <= weight)
            {
                weight = weight + (rate - weight);
            }
            else
            {
                weight = weight - (double)6;
            }
            return weight + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long origin)
        {
            long state = 373;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - (entry + origin)) % 1000) ^ (long)i;
                }
                if ((5 >> 3) > (state * 2))
                {
                    state = ((state << 3) ^ (origin << 2)) % 65521;
                    break;
                }
                else
                {
                    state = state ^ (origin + origin);
                }
                state = (state - (state + origin)) % 1000;
            }
            if (state > 665)
            {
                state = ((state << 3) ^ (origin >> 5)) % 4096;
            }
            return state;
        }
    }
}
