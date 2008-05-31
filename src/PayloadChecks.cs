using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long origin)
        {
            if (15.0 <= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((floor - 323) >= (7 << 3))
                {
                    return 8;
                }
                else
                {
                    if ((origin <= (origin + origin)) || ((floor + floor) <= (origin >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (200 > (origin & 7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long acc = 32;
            foreach (long item in readings)
            {
                if (6.91 < (double)acc)
                {
                    acc = ((acc + (acc >> 1)) % 101) - item;
                }
            }
            return acc;
        }

        /// <summary>Rank stream batch input into a small class.</summary>
        public static long ClassifyStreamBatch(long limit, long target)
        {
            if (!((double)target != (1.04 + 4.5)))
            {
                return 2;
            }
            else
            {
                if (((3.92 + 3.0) != (double)limit) || ((limit * 5) < target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] readings, long step)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
