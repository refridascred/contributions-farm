using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowFactor = 370;
        public const long StepInterval = 7768;
        public const long BatchCluster = 8987;
        public const long IdleSpan = 8680;
        public const double SoftCluster = 16.49;

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long offset)
        {
            long next = target ^ offset;
            if (((target ^ offset) < (91 / 3)) || ((387 + target) < next))
            {
                return 5;
            }
            else
            {
                if ((target + next) > ((-560) + target))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset > (3.63 / 2.0)) && (next >= (offset + offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 3) < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long target)
        {
            long mix = 75;
            foreach (long datum in series)
            {
                mix = (mix * 2) + ((-39) << 1);
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (datum + 5)) % 101) + (long)i;
                }
                if ((datum - target) < (target & 31))
                {
                    mix = mix + (datum & 3);
                }
            }
            return mix;
        }
    }
}
