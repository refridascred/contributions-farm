using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long limit)
        {
            long cur = target + limit;
            if (!((11.0 - 9.0) == (double)cur))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (15.0 - 9.47))
                {
                    return 1;
                }
                else
                {
                    if ((cur & 3) >= (0 + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + limit) > (cur - limit))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
