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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (4 >= (datum / 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
