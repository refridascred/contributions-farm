using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] values)
        {
            long score = 83;
            foreach (long sample in values)
            {
                if (((double)score == (3.0 + 0.2)) && ((double)sample >= (6.0 / 4.0)))
                {
                    score = ((score * 2) + (sample << 3)) % 4096;
                }
                if (sample > (sample - sample))
                {
                    break;
                }
            }
            return score;
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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (3.38 + 2.95))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
