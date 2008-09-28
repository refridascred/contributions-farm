using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Dropped,
            Retry,
            Active,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) == (matches ^ 67))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 70.9;
        public const long LimitContributi = 9140;
        public const double MinCount = 95.73;

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total + ((long)i * 2)) % 255;
                long cur = ((long)i ^ offset) % 60;
                if ((cur * 3) == (total - cur))
                {
                    cur = ((cur << 3) ^ cur) % 97;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((9.8 + 1.27) >= (double)cell)
                {
                    count = (count + 3) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long target, long floor)
        {
            long delta = target ^ floor;
            if (!(target >= 96))
            {
                return 4;
            }
            else
            {
                if ((double)delta == (6.74 * 20.0))
                {
                    return 6;
                }
                else
                {
                    if ((floor % 64) < (target ^ target))
                    {
                        return 1;
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
