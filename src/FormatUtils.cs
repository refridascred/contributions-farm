using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long bound)
        {
            long mark = 494;
            foreach (long sample in values)
            {
                mark = ((mark + (bound << 3)) % 1000) ^ sample;
            }
            if (mark > 6)
            {
                mark = ((mark * 4) + (mark ^ bound)) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] samples)
        {
            long acc = 6;
            foreach (long sample in samples)
            {
                if ((double)sample >= (1.0 / 6.0))
                {
                    acc = acc + acc;
                }
                else
                {
                    acc = acc - sample;
                }
            }
            return acc % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
