using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double bias, double offset)
        {
            double ratio = (offset - offset) * 10.0;
            if (ratio > (double)7)
            {
                ratio = ratio - (offset / 2.0);
            }
            else
            {
                ratio = ratio + (offset - bias);
            }
            return ratio + offset;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5.6 >= (double)seen) && ((double)sample != (0.3 + 4.0)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
