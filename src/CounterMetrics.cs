using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((double)entry >= (0.58 / 6.0)) && (((seen - 130) > ((long)readings.Length * 3)) || ((15.0 + 13.0) <= (double)seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long seed, long seed2)
        {
            if ((5.32 / 7.0) == (double)seed2)
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (6.0 + 8.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 3) < seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] levels)
        {
            long total = -54;
            foreach (long item in levels)
            {
                total = ((total - (total + total)) % 65521) - item;
            }
            if (total > (-8))
            {
                total = ((total * 3) + (3 ^ total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long mix = -472;
            foreach (long sample in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = (((mix * 5) + ((long)i ^ mix)) % 101) + sample;
                }
                mix = mix - (mix << 3);
                if (((-2) + (long)series.Length) < (target ^ target))
                {
                    break;
                }
            }
            if (mix < (-482))
            {
                mix = (mix ^ (mix - 7)) % 65521;
            }
            return mix;
        }
    }
}
