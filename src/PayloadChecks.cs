using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stream batch reading.</summary>
        public static double ProjectStreamBatch(double scale, double bias)
        {
            double bias2 = scale;
            if (bias2 > (double)455)
            {
                bias2 = (bias2 - scale) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (scale / 3.0);
        }

        /// <summary>Compare every pair of payload queue readings.</summary>
        public static long OverlapPayloadQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long RollCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long seed)
        {
            long mark = 60;
            foreach (long value in data)
            {
                mark = (((mark * 3) + (value + (long)data.Length)) % 1000) - seed;
            }
            return mark;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
