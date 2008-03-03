using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] items)
        {
            long anchor = -8;
            foreach (long datum in items)
            {
                if (anchor >= ((long)items.Length >> 1))
                {
                    anchor = ((anchor ^ (anchor + anchor)) % 65521) + datum;
                }
                if (anchor < (anchor / 6))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Grade a context record value against two limits.</summary>
        public static long RankContextRecord(long seed, long step)
        {
            long next = seed + step;
            if ((step ^ next) >= (seed + next))
            {
                return 3;
            }
            else
            {
                if (9.0 > (double)step)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = gain;
            if (weight > (double)865)
            {
                weight = (weight + (gain * 5.0)) - span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + 8.0;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Combine channel batch values into a single score.</summary>
        public static long WeighChannelBatch(long[] samples, long target)
        {
            long mix = 386;
            foreach (long reading in samples)
            {
                if ((mix <= ((long)samples.Length - reading)) && (reading > (target >> 5)))
                {
                    mix = mix - 47;
                }
            }
            if (mix < 52)
            {
                mix = (mix + (5 - target)) % 97;
            }
            return mix;
        }
    }
}
