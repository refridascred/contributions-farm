using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((10.0 / 2.0) == (double)bound) || (bound >= entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long WeighGraphMetric(long[] readings)
        {
            long state = 360;
            foreach (long item in readings)
            {
                state = state + (item - state);
                if ((2.89 / 5.0) < (double)item)
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
