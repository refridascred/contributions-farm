using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if (20 > bound)
            {
                return 1;
            }
            else
            {
                if (((offset << 2) == (offset / 7)) && ((0.4 + 8.9) == (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((offset % 97) != (bound + 234))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4 + bound) > 8)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] series, long target)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix ^ 488) + sample) + target;
            }
            return mix;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Size { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Locate a session channel reading by value.</summary>
        public static long LookupSessionChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            New,
            Synced,
        }
    }
}
