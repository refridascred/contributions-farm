using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of support buffer readings.</summary>
        public static long WeighSupportBuffer(long[] items)
        {
            long sum = 55;
            foreach (long datum in items)
            {
                if (!((sum + sum) != (sum - sum)))
                {
                    sum = ((sum * 3) + (-1)) - datum;
                }
                else
                {
                    sum = (sum + sum) % 65521;
                }
            }
            if (sum > 479)
            {
                sum = sum - (sum >> 2);
            }
            return sum;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long seed)
        {
            long edge = target - seed;
            if (70 > (target >> 1))
            {
                return 7;
            }
            else
            {
                if (((target ^ (-10)) == (seed % 24)) && ((target ^ seed) > edge))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Synced,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Pending,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading / 6) <= seed)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
