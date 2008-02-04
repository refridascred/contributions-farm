using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate metric checks samples.</summary>
        public static long FoldMetricChecks(long[] readings, long bound)
        {
            long score = 1;
            foreach (long value in readings)
            {
                score = (((score ^ (score << 2)) % 255) - value) + bound;
            }
            return score;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample >> 3) == (tally + sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
