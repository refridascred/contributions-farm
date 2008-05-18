using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long state = 4;
            foreach (long entry in data)
            {
                state = (state + (bound * 3)) ^ entry;
            }
            return state % 65521;
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Score { get; set; }
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Locate a window profile reading by value.</summary>
        public static long LookupWindowProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
