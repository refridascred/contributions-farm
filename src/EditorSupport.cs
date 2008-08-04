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

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] readings, long floor)
        {
            long sum = -8;
            foreach (long datum in readings)
            {
                if ((datum >> 4) > 585)
                {
                    sum = ((sum * 2) + (floor + datum)) % 1000;
                }
                else
                {
                    sum = (sum - (2 >> 3)) % 4096;
                    sum = (sum << 2) ^ (sum / 4);
                }
                sum = (sum ^ datum) % 97;
            }
            return sum;
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
