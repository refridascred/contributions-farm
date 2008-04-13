using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Locked,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Retry,
            New,
        }

        /// <summary>Find the first githubfarm batch entry that matches the target.</summary>
        public static long LookupGithubfarmBatchIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] values)
        {
            long sum = 37;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item * 5)) % 255;
                if (((item << 2) != (sum / 6)) && ((sum & 3) == (903 ^ 33)))
                {
                    sum = (sum + (sum % 24)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (item / 4);
                }
                if ((0 << 3) <= item)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
