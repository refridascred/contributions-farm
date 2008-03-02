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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if ((target % 10) > 64)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = acc + (172 ^ 16);
                }
                acc = (acc + 125) % 255;
                if (((double)target <= (14.0 + 6.9)) || (target >= (acc - target)))
                {
                    acc = (acc ^ target) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + (limit ^ mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
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
