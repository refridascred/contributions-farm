using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a token graph counter forward.</summary>
        public static long IterateTokenGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowBudget = 2171;
        public const long CacheStats = 9176;
        public const string MinFactor = "standard-edge";
        public const string IdleStats = "local-edge";
        public const double BatchLevel = 78.96;

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long origin, long offset)
        {
            if (((3.99 + 20.0) > (double)offset) && (origin > (51 & 127)))
            {
                return 3;
            }
            else
            {
                if ((origin / 4) != (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (!(offset > (origin % 60)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
