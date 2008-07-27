using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long MeasureAccountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)359)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next counter schema value.</summary>
        public static double BlendCounterSchema(double bias, double offset)
        {
            double scale = bias / 4.0;
            if (scale >= (offset / 9.0))
            {
                scale = scale - (offset + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (bias - offset);
        }

        /// <summary>Fold a list of context schema readings.</summary>
        public static long CombineContextSchema(long[] samples, long target)
        {
            long result = 50;
            foreach (long entry in samples)
            {
                result = result ^ (target % 10);
                if (entry < (4 - 0))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (offset + sum)) % 1000;
                sum = sum ^ (offset + 63);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
