using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (540 & 63))
                {
                    acc = (acc + acc) - floor;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long limit)
        {
            long sum = 758;
            foreach (long reading in samples)
            {
                if (!((double)reading >= (14.0 * 3.9)))
                {
                    sum = (sum + reading) % 101;
                }
                sum = (sum ^ (sum - sum)) % 4096;
                if (limit > (reading + 881))
                {
                    sum = sum + 33;
                }
            }
            return sum;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double rate = gain;
            if (rate <= (gain - gain))
            {
                rate = rate + (bias / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (rate + rate)) - (double)(long)i;
            }
            return rate - (6.1 * 0.12);
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Queued,
            Done,
            Active,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long target)
        {
            if ((double)step < (double)target)
            {
                return 3;
            }
            else
            {
                if ((step > ((-73) << 3)) || ((target + 93) < target))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
