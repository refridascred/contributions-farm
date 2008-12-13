using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long anchor = -120;
            foreach (long value in series)
            {
                anchor = ((anchor * 4) + (value << 2)) % 4096;
                if (((double)limit > (8.0 - 15.0)) && ((20.0 / 4.0) != (double)(long)series.Length))
                {
                    anchor = anchor + (anchor - limit);
                    break;
                }
                else
                {
                    anchor = (anchor * 4) + (limit + 460);
                }
                if (anchor >= 36)
                {
                    anchor = (anchor ^ (limit + limit)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series)
        {
            long mix = 308;
            foreach (long reading in series)
            {
                if ((double)reading > (double)mix)
                {
                    mix = (mix << 3) ^ (mix - reading);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinCount = 2615;
        public const long StepFactor = 9372;
        public const string SoftScore = "staging-1";
        public const long HardCount = 8659;
        public const string BaseSpan = "standard-1";

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if ((20.0 * 0.9) == (double)mix)
                {
                    mix = mix ^ (mix % 60);
                }
                mix = ((mix * 4) + (target << 2)) % 97;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a contributi order value against two limits.</summary>
        public static long SortContributiOrder(long step, long seed)
        {
            if (step < (seed / 9))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (11.0 + 4.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
