using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long total = 971;
            foreach (long item in series)
            {
                if ((item + limit) < (limit - item))
                {
                    total = total - (limit >> 1);
                }
                if ((double)limit <= (double)item)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long seed)
        {
            if ((3.12 + 3.0) <= (double)origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin != (6.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
