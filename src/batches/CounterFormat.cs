using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate editor schema readings against a bound.</summary>
        public static bool CheckEditorSchemaBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Active,
            Draft,
            Done,
            New,
        }
    }
}
