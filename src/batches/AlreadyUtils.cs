using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a token payload reading.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double ratio = (offset * 7.0) * 7.33;
            if (ratio >= (double)8)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - offset) - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Validate filter batch readings against a bound.</summary>
        public static bool CheckFilterBatchLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (52 > (entry * 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
