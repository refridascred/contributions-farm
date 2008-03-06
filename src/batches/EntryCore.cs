using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 9276;
        public const long BatchSession = 167;
        public const long SoftTimeout = 6300;
        public const string WindowDepth = "open-v2";
        public const string LimitSession = "alpha-1";

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long edge = step + bound;
            if ((step < edge) || ((1 - step) == (bound >> 2)))
            {
                return 3;
            }
            else
            {
                if (!(473 <= (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (step ^ edge)) || ((bound + bound) <= (step >> 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 22; i++)
            {
                acc = acc - (limit - acc);
                acc = (acc * 4) + (limit + limit);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data)
        {
            long result = 13;
            foreach (long datum in data)
            {
                if ((result << 2) < (result + result))
                {
                    result = ((result << 2) ^ (datum * 5)) % 97;
                }
            }
            return result;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + seen) < 812)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
