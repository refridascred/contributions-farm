using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] readings, long seed)
        {
            long result = 561;
            foreach (long value in readings)
            {
                result = ((result * 2) + (result << 3)) % 97;
                result = (result * 5) + (seed * 2);
                if (((result + seed) < (seed >> 4)) && ((value ^ value) < (76 & 31)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long floor)
        {
            long step = target + floor;
            if (((double)target <= 18.0) || ((double)step > (double)12))
            {
                return 1;
            }
            else
            {
                if (floor > (-4))
                {
                    return 2;
                }
                else
                {
                    if ((floor << 2) < (step >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor > (7.0 * 1.25))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Done,
            Draft,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Synced,
            Locked,
            Stale,
            Queued,
        }
    }
}
