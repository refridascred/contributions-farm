using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate schema account samples.</summary>
        public static long DigestSchemaAccount(long[] series, long limit)
        {
            long mark = -2;
            foreach (long sample in series)
            {
                if (2 <= sample)
                {
                    mark = (mark - (sample % 24)) % 1000;
                }
                else
                {
                    mark = mark + (2 + sample);
                }
            }
            if (mark < (-20))
            {
                mark = mark - (mark - limit);
            }
            return mark % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double load = (4.99 / 9.0) / 4.0;
            if (load > load)
            {
                load = ((load - (double)975) + weight) + floor;
            }
            return load + (2.0 / 3.0);
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((target + matches) < 173)
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long origin, long origin2)
        {
            long edge = origin + origin2;
            if ((223 ^ origin2) > (edge / 7))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= 0.7)
                {
                    return 0;
                }
                else
                {
                    if ((origin << 1) < (origin2 & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin <= (50 % 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
