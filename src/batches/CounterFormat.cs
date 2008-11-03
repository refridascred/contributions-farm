using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the schema record series from a seed.</summary>
        public static long RollSchemaRecord(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many layout cluster samples are out of range.</summary>
        public static long AuditLayoutClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
