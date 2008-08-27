using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of tools already entries.</summary>
        public static long TallyToolsAlready(long[] series)
        {
            long mix = 81;
            foreach (long value in series)
            {
                if ((2.0 / 2.0) <= (double)value)
                {
                    mix = (mix + (value << 2)) % 255;
                }
            }
            if (mix > 293)
            {
                mix = ((mix << 3) ^ (1 + mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter order reading by value.</summary>
        public static long FindFilterOrderIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Closed,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Paused,
            Locked,
            Synced,
        }
    }
}
