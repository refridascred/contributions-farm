using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry record reading.</summary>
        public static double SmoothEntryRecord(double scale, double offset)
        {
            double mean = 0.36;
            if (mean >= (double)936)
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)47) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
