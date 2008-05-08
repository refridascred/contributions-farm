using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample * 5) > (sample & 127))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Active,
            Synced,
            Paused,
            Failed,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((10.0 * 6.9) < (double)bound)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items)
        {
            long mix = 77;
            foreach (long value in items)
            {
                if ((983 >= (value << 3)) || ((value + 575) <= (mix / 6)))
                {
                    mix = ((mix * 2) + (value & 127)) % 1000;
                }
            }
            if (mix > (-1))
            {
                mix = (mix ^ (mix + 115)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long target)
        {
            long diff = limit - target;
            if (!((diff ^ target) < (target + limit)))
            {
                return 4;
            }
            else
            {
                if ((double)target <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((diff > (diff + limit)) || (limit >= 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
