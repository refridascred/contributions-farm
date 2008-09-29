using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long sum = -935;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = ((sum ^ datum) % 101) - (long)i;
                }
                if (!(sum <= 823))
                {
                    sum = (sum ^ (floor / 6)) % 255;
                }
            }
            if (sum < 6)
            {
                sum = (sum + ((long)values.Length * 4)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
