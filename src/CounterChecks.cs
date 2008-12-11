using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Count record commits pairs that satisfy a relation.</summary>
        public static long OverlapRecordCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long offset, long origin)
        {
            long lane = offset + origin;
            if ((lane & 31) >= (origin * 5))
            {
                return 6;
            }
            else
            {
                if ((lane * 4) > lane)
                {
                    return 0;
                }
                else
                {
                    if (((6.6 - 4.7) == (double)origin) || ((offset * 5) <= 351))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((lane + offset) < 670)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Queued,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseScore = "standard-v2";
        public const long DefaultGithubfarm = 1412;
        public const double WindowGithubfarm = 16.08;
        public const long SoftGithubfarm = 1422;
    }
}
