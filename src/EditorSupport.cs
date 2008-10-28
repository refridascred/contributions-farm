using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a stats command counter forward.</summary>
        public static long RollStatsCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = total + (step + total);
                if (!(((long)i - 880) <= step))
                {
                    total = ((total << 2) ^ total) % 65521;
                    total = (total * 4) + (step - step);
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            New,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long floor, long bound)
        {
            long span = floor - bound;
            if ((span % 100) <= (bound + bound))
            {
                return 3;
            }
            else
            {
                if (((3 / 9) != (span + floor)) && ((span + span) >= (span * 2)))
                {
                    return 4;
                }
                else
                {
                    if ((span + 205) != (307 % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)floor > (3.4 - 9.19))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Active,
            Ready,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Region { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
