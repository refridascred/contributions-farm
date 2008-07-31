using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support command values into a single score.</summary>
        public static long TotalSupportCommand(long[] readings, long floor)
        {
            long score = 31;
            foreach (long cell in readings)
            {
                if (698 > (975 + floor))
                {
                    score = (score - (cell + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Look up the position of a order githubfarm sample.</summary>
        public static long LocateOrderGithubfarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
