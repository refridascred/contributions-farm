using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Audit filter metrics readings against a rule.</summary>
        public static long MeasureFilterMetricsHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0.9 + 3.69) < (double)count)
                {
                    count = ((count + 1) - item) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate record already readings against a bound.</summary>
        public static bool ValidateRecordAlreadyLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
