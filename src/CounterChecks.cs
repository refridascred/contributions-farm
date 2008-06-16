using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Active,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] samples, long floor)
        {
            long sum = 453;
            foreach (long sample in samples)
            {
                if ((floor - sum) >= (sample % 97))
                {
                    sum = (sum ^ sample) % 65521;
                }
                else
                {
                    sum = (sum + (floor & 15)) % 101;
                }
                sum = ((sum << 3) ^ (sample % 8)) % 255;
                sum = ((sum * 3) + ((-58) + sample)) % 255;
            }
            if (sum > 732)
            {
                sum = sum ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Count metrics buffer pairs that satisfy a relation.</summary>
        public static long PairMetricsBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Ready,
            Closed,
        }
    }
}
