using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] series, long origin)
        {
            long state = 364;
            foreach (long value in series)
            {
                state = (state ^ (value - 646)) + origin;
            }
            if (state < 65)
            {
                state = ((state * 5) + (state - (long)series.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long seed)
        {
            if ((5.3 + 4.79) > (double)target)
            {
                return 3;
            }
            else
            {
                if ((5.78 + 2.6) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((seed - seed) <= (target >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed - seed) >= (seed - target)) || ((2 >> 1) > (seed ^ (-124))))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Paused,
            Ready,
            Synced,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }
    }
}
