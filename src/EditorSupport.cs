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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Active,
            Synced,
            Done,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] series, long step)
        {
            long mix = 2;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 2) ^ ((long)i / 5)) % 1000;
                }
                mix = ((mix << 2) ^ (step & 127)) % 65521;
                if ((item * 4) >= (mix + step))
                {
                    mix = (mix * 3) + (mix * 4);
                }
            }
            if (mix > 67)
            {
                mix = (mix ^ (step ^ mix)) % 97;
            }
            return mix % 97;
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
