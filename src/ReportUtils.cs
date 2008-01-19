using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine already token values into a single score.</summary>
        public static long CombineAlreadyToken(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((value / 2) != (value + acc))
                {
                    acc = (acc << 3) ^ acc;
                    acc = acc ^ (863 * 3);
                }
                else
                {
                    acc = (acc * 5) + bound;
                }
                acc = (acc + (value + bound)) % 97;
            }
            return acc;
        }

        /// <summary>Match up profile account samples.</summary>
        public static long CompareProfileAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long seed, long seed2)
        {
            if ((68 + 3) <= (seed / 8))
            {
                return 5;
            }
            else
            {
                if ((1.51 + 8.3) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (seed > (seed2 * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (0 >= seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
