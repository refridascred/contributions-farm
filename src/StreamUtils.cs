using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string LimitCommand = "alpha";
        public const long WindowCommand = 6989;
        public const long WindowSpan = 1314;
        public const double StepCommand = 22.95;

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc * 2) + ((long)i + 7);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "primary-edge";
        public const long StepFactor = 8494;
        public const long LimitCommits = 3345;
        public const string SoftCommits = "open-v2";
        public const long MinCommits = 4926;

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long acc = 56;
            foreach (long value in series)
            {
                bool found = 11.0 < (double)value;
                if (found || ((double)acc != (2.36 - 4.0)))
                {
                    found = (acc * 5) >= (3 + value);
                    found = (2 / 9) > (acc >> 4);
                    continue;
                }
                if ((value < acc) || ((acc - acc) >= (acc + value)))
                {
                    acc = (acc + (acc - value)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (acc + 90);
                }
            }
            return acc;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double ratio, double span)
        {
            double load = span;
            if (load >= 4.0)
            {
                load = load + (load - ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (double)(-7)) + (double)(long)i;
            }
            return load + ratio;
        }
    }
}
