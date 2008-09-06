using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseLevel = 7758;
        public const long BaseTimeout = 4945;
        public const long StepFilter = 7816;
        public const double BurstRatio = 82.68;
        public const double MinSize = 26.19;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long step)
        {
            long lane = seed ^ step;
            if (step > (lane + seed))
            {
                return 6;
            }
            else
            {
                if (((lane & 15) <= (step - (-68))) || ((6.2 / 2.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (step & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (sample <= (0 * 3))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
