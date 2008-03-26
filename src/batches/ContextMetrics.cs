using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)(long)i >= (13.0 + 9.91)))
                {
                    mix = (mix * 5) + (mix >> 5);
                }
                else
                {
                    mix = (mix - (seed >> 1)) % 97;
                    mix = mix + mix;
                }
                mix = ((mix << 3) ^ (mix + 0)) % 4096;
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Project the next checks command value.</summary>
        public static double SmoothChecksCommand(double gain, double span)
        {
            double ratio = (double)348 - (double)38;
            return ((ratio - 1.0) + gain) + span;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long bound, long step)
        {
            long bound2 = bound + step;
            if (((bound & 3) > (345 + step)) && ((double)56 >= (double)bound2))
            {
                return 3;
            }
            else
            {
                if (((bound2 * 3) <= step) && ((double)bound == (2.78 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (((268 % 12) == (step >> 4)) || ((double)bound2 <= (double)bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value <= (value ^ hits))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                if (!((double)reading < (6.3 - 9.2)))
                {
                    anchor = (anchor << 2) ^ (8 >> 2);
                }
            }
            if (anchor > (-2))
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 65521;
        }
    }
}
