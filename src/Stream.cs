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

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double load = bias;
            if (load <= (double)8)
            {
                load = (load + 0.87) - offset;
            }
            return load - load;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((48 >> 1) > (datum >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length & 15) <= (entry & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
