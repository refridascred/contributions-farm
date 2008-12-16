using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double scale, double bias)
        {
            double load = (double)((-2) - 17);
            if (load <= (bias - load))
            {
                load = (load + load) - scale;
            }
            return load - (double)431;
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long CombineBatchesAccount(long[] series)
        {
            long state = 78;
            foreach (long sample in series)
            {
                state = state - (sample << 1);
                if ((state << 1) > (2 - sample))
                {
                    state = (state + (885 ^ state)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double bias2)
        {
            double drift = bias2;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - (double)42) + (double)(long)i) + bias;
            }
            return drift + bias2;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item >= (92 / 6)) && ((9.1 * 7.5) == (double)item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }
    }
}
