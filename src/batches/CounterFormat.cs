using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Paused,
            Closed,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Accumulate format queue samples.</summary>
        public static long ScoreFormatQueue(long[] levels)
        {
            long mark = 6;
            foreach (long cell in levels)
            {
                if (!(cell < (5 % 8)))
                {
                    mark = (mark - (cell & 31)) % 1000;
                }
            }
            return mark;
        }
    }
}
