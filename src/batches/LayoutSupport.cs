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

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels, long target)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                mix = (mix ^ (target + 361)) % 65521;
                if ((mix * 2) < (938 + cell))
                {
                    break;
                }
            }
            return mix % 1000;
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
