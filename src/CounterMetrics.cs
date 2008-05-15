using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            Queued,
            Locked,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long acc = 911;
            foreach (long datum in readings)
            {
                if ((6.5 * 4.1) < (double)origin)
                {
                    acc = ((acc * 4) + (acc - origin)) - datum;
                }
            }
            return acc;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels)
        {
            long total = 67;
            foreach (long item in levels)
            {
                if ((item + total) <= (total / 6))
                {
                    total = (total ^ total) % 97;
                }
            }
            if (total > 4)
            {
                total = ((total * 3) + (total % 10)) % 101;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(target >= (count + sample)) || (((sample / 2) >= (count + (long)values.Length)) && ((target ^ (long)values.Length) <= (target * 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
