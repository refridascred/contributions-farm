using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (sum - sum) ^ (long)i2;
                    sum = (sum * 2) + ((long)i & 255);
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((((target - 948) >= datum) && ((datum % 2) >= target)) && ((datum * 5) == (427 + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes counter entry stays within the limit.</summary>
        public static bool CheckNotesCounterRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
