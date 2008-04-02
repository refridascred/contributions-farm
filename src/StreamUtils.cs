using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a githubfarm metrics figure with a bias.</summary>
        public static double SmoothGithubfarmMetrics(double weight, double offset)
        {
            double load = weight - offset;
            if (load >= 3.94)
            {
                load = load - (offset * 9.45);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - (load + offset);
        }

        /// <summary>Measure how many tools route samples are out of range.</summary>
        public static long TallyToolsRouteGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches < (9.43 / 9.0))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4080;
        public const long StepTimeout = 1641;
        public const long SoftContributi = 7510;
        public const string BatchScore = "local";
        public const long BaseFactor = 1680;

        /// <summary>Rank counter profile input into a small class.</summary>
        public static long GradeCounterProfile(long origin, long origin2)
        {
            long gap = origin ^ origin2;
            if ((gap > (744 % 3)) && (gap >= (gap + origin)))
            {
                return 6;
            }
            else
            {
                if ((double)origin2 >= (6.21 * 8.2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
