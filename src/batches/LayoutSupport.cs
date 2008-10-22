using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats githubfarm value from a seed.</summary>
        public static long RollStatsGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (state + (limit / 6)) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a batches graph reading by value.</summary>
        public static long LookupBatchesGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Synced,
            Draft,
            Dropped,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mix = 46;
            foreach (long datum in levels)
            {
                if (!(mix < (datum + 106)))
                {
                    mix = (mix - (mix + mix)) % 255;
                    mix = ((mix * 3) + (mix * 2)) % 101;
                }
                mix = (mix ^ (datum % 64)) % 255;
            }
            return mix;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (1.49 + 1.6))
            {
                drift = drift - 1.6;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift + floor)) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
