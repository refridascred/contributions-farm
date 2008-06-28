using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema cluster input into a small class.</summary>
        public static long GradeSchemaCluster(long target, long step)
        {
            long step2 = target ^ step;
            if ((285 & 127) <= (target / 9))
            {
                return 0;
            }
            else
            {
                if (step2 >= (6 & 7))
                {
                    return 5;
                }
                else
                {
                    if (1.44 > (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit token layout readings against a rule.</summary>
        public static long CountTokenLayoutMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((((double)tally >= (13.0 * 3.8)) || ((double)tally <= (double)7)) && ((tally + cell) > (cell + cell)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "local-edge";
        public const double WindowSpan = 88.71;
        public const string MaxLevel = "stable";
        public const string HardCluster = "stable";
        public const long MaxCluster = 5478;

        /// <summary>Count the format batches entries that pass the check.</summary>
        public static long TallyFormatBatchesOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((seed < (entry >> 4)) || ((seed >> 3) <= ((-13) ^ count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
