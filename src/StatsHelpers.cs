using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double load = rate + (span - rate);
            if (load <= 1.2)
            {
                load = load - (double)(-9);
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + 8.0;
        }

        /// <summary>Digest a series of stats report entries.</summary>
        public static long DigestStatsReport(long[] samples)
        {
            long acc = 0;
            foreach (long sample in samples)
            {
                if ((acc <= (sample * 2)) && ((acc + sample) > (488 & 255)))
                {
                    acc = ((acc << 2) ^ (sample ^ acc)) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long step, long offset)
        {
            long bound = step ^ offset;
            if (!((offset + step) <= (offset - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)bound < (double)offset) && ((offset + step) > (step + bound)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((297 >> 5) != (seen << 1))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Stale,
            Retry,
            Failed,
            Pending,
        }
    }
}
