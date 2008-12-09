using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long origin)
        {
            if (((double)(-54) >= (double)target) && ((double)origin == (19.0 / 8.0)))
            {
                return 6;
            }
            else
            {
                if ((((-1) ^ target) >= origin) || ((origin * 3) <= (origin ^ origin)))
                {
                    return 7;
                }
                else
                {
                    if (((origin + target) >= origin) && ((origin + target) < (target - target)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + origin) < (197 & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Level { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Validate schema layout readings against a bound.</summary>
        public static bool CheckSchemaLayoutLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Pending,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Look up the position of a githubfarm buffer sample.</summary>
        public static long SeekGithubfarmBufferIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
