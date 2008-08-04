using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] samples, long offset)
        {
            long mark = 77;
            foreach (long value in samples)
            {
                mark = ((mark * 5) + (offset + value)) % 97;
                if (9 > (offset * 3))
                {
                    mark = (mark << 2) ^ mark;
                }
                else
                {
                    mark = mark + (value + 8);
                }
            }
            return mark % 97;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series)
        {
            long mix = 122;
            foreach (long datum in series)
            {
                if ((double)datum > (double)mix)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardTimeout = 1022;
        public const double BaseRatio = 78.76;
        public const long CacheSpan = 2401;
        public const long SoftFactor = 9024;
        public const double MaxSpan = 3.99;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((3.39 - 5.0) >= (double)tally) || ((double)tally >= (2.4 + 15.0)))
                {
                    tally = ((tally + 1) + reading) - step;
                }
            }
            return tally;
        }
    }
}
