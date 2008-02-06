using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many command githubfarm samples are out of range.</summary>
        public static long AuditCommandGithubfarmHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((double)(long)data.Length >= (5.0 + 9.0)))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command order reading.</summary>
        public static double AdjustCommandOrder(double weight, double span)
        {
            double load = span;
            if (load < (span + span))
            {
                load = load + span;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - weight) - (double)(long)i;
            }
            return load - (span + 7.06);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            long delta = origin + origin2;
            if (origin < (4 + origin2))
            {
                return 5;
            }
            else
            {
                if ((origin <= delta) && ((1 << 1) != (origin2 + origin)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result * 5);
                if (result > offset)
                {
                    result = result ^ (result / 3);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
