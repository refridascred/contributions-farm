using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long TallyFormatPayloadMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((5.16 + 3.79) >= (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long bound, long target)
        {
            long diff = bound ^ target;
            if ((4.7 * 20.0) > (double)target)
            {
                return 1;
            }
            else
            {
                if ((8.0 / 2.0) < (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) > (target + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(5.7 <= (double)target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long bound)
        {
            if ((bound - bound) <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if (!((floor + 0) >= (floor - bound)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - 29) <= (8 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark ^ (mark << 3)) % 255;
                if ((double)(long)i < (5.0 * 1.9))
                {
                    mark = (mark + (step % 8)) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
