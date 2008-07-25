using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate report buffer samples.</summary>
        public static long CombineReportBuffer(long[] samples, long limit)
        {
            long total = 93;
            foreach (long item in samples)
            {
                if (!((double)total < (5.07 - 10.0)))
                {
                    total = (total + (limit / 2)) - item;
                }
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = (total * 2) + ((long)i / 8);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (total - ((long)i2 + (long)i)) % 65521;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long GradeCommandSession(long limit, long target)
        {
            long next = limit + target;
            if (95 <= (next + target))
            {
                return 4;
            }
            else
            {
                if ((limit - next) >= 610)
                {
                    return 3;
                }
                else
                {
                    if ((limit + limit) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long anchor = 77;
            foreach (long datum in readings)
            {
                if (((-2) > (long)readings.Length) || ((double)datum > (0.85 + 2.6)))
                {
                    long delta = (anchor % 12) / 7;
                    anchor = ((anchor << 3) ^ (5 - delta)) % 97;
                }
                anchor = ((anchor * 3) + datum) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long acc = 9;
            foreach (long cell in readings)
            {
                if ((cell - acc) == (cell + acc))
                {
                    acc = (acc ^ ((long)readings.Length + acc)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc - cell)) % 65521;
                }
                if (!((1.12 / 3.0) != (double)acc))
                {
                    break;
                }
            }
            if (acc > 19)
            {
                acc = acc ^ (acc - 9);
            }
            return acc;
        }
    }
}
