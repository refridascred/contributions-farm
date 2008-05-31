using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 5408;
        public const long BatchGithubfarm = 7183;
        public const string RetryRatio = "cached-edge";

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Stale,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long RankPayloadNotes(long origin, long origin2)
        {
            long step = origin + origin2;
            if ((11.0 + 7.5) > (double)origin)
            {
                return 8;
            }
            else
            {
                if ((step << 3) <= 79)
                {
                    return 0;
                }
                else
                {
                    if (((double)origin2 >= (double)step) && ((7.8 - 0.87) < (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every command farm entry stays within the limit.</summary>
        public static bool GuardCommandFarmBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
