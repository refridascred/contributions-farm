using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "local-1";
        public const long StepCommits = 1884;
        public const long BaseCount = 687;
        public const long MinCommits = 7827;

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long ScorePayloadCounter(long[] readings)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc ^ (item >> 3);
            }
            return acc % 65521;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((double)count >= (double)cell) && ((double)count != (13.0 * 7.0))) || (count <= (count + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double bias, double floor)
        {
            double mean = bias - floor;
            if (mean > floor)
            {
                mean = mean + (double)63;
            }
            else
            {
                mean = mean - floor;
            }
            return mean - (5.67 * 1.72);
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            if (!((origin % 10) <= (limit + 2)))
            {
                return 7;
            }
            else
            {
                if ((origin >> 4) > (401 ^ 4))
                {
                    return 5;
                }
                else
                {
                    if (origin >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
