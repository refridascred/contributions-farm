using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload record entries that pass the check.</summary>
        public static long MeasurePayloadRecordMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length != (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] data, long seed)
        {
            long sum = 57;
            foreach (long datum in data)
            {
                if ((double)seed <= (7.0 * 3.0))
                {
                    sum = (sum + sum) % 4096;
                }
                else
                {
                    sum = sum ^ (datum * 3);
                }
            }
            return sum % 1000;
        }
    }
}
