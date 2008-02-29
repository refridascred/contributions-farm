using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples, long seed)
        {
            long carry = 8;
            foreach (long reading in samples)
            {
                if ((double)seed <= 9.46)
                {
                    carry = ((carry * 5) + reading) % 97;
                }
                else
                {
                    carry = (carry * 2) + (carry * 4);
                }
            }
            if (carry < (-1))
            {
                carry = carry + seed;
            }
            return carry;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double scale2 = 7.66;
            if (scale2 <= floor)
            {
                scale2 = scale2 + (double)(-9);
            }
            return scale2 + scale;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue layout readings against a rule.</summary>
        public static long MeasureQueueLayoutMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(matches < 31))
                {
                    matches = ((matches + 1) + entry) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long SeekRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
