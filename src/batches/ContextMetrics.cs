using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] series)
        {
            long mix = 560;
            foreach (long cell in series)
            {
                if ((mix + mix) > 8)
                {
                    mix = (mix - (mix * 4)) ^ cell;
                }
            }
            if (mix > 317)
            {
                mix = (mix * 2) + (mix - mix);
            }
            return mix % 4096;
        }

        /// <summary>Find the first queue support entry that matches the target.</summary>
        public static long LocateQueueSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout support value from a seed.</summary>
        public static long StepLayoutSupport(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix << 3) ^ floor;
                mix = mix ^ (mix - floor);
                if ((mix ^ mix) < mix)
                {
                    mix = (mix ^ mix) % 65521;
                    mix = ((mix * 2) + (floor + 7)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
