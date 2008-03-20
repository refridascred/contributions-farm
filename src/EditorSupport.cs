using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long state = 8;
            foreach (long entry in series)
            {
                if ((double)bound > (double)64)
                {
                    state = (state - (bound - 43)) % 4096;
                    continue;
                }
                if (state < (state - state))
                {
                    state = (state - (entry & 127)) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - (anchor - (long)i);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public double Flag { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long WeighEditor(long[] levels, long origin)
        {
            long score = 58;
            foreach (long item in levels)
            {
                score = (((score + score) % 255) + item) - origin;
            }
            return score % 65521;
        }
    }
}
