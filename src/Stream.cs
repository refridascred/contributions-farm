using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Find the first githubfarm contributi entry that matches the target.</summary>
        public static long LocateGithubfarmContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Done,
            Pending,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count * 4) <= (cell >> 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples, long target)
        {
            long sum = 638;
            foreach (long cell in samples)
            {
                sum = ((sum - sum) + cell) + target;
            }
            return sum;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((((long)i ^ total) < (long)i) || ((total & 1) != (limit << 2)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (total + total)) % 4096;
                    total = ((total * 5) + (total & 1)) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
