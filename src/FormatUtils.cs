using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = 447;
            foreach (long entry in series)
            {
                anchor = (anchor + (entry + anchor)) % 255;
            }
            return anchor;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Idle,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if (offset >= (offset % 100))
            {
                return 2;
            }
            else
            {
                if ((28 << 2) >= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if ((seed + offset) < offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if (5.9 >= (double)offset)
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
    }
}
