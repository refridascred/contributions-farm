using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate record cache readings against a bound.</summary>
        public static bool VerifyRecordCacheBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            New,
            Active,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + (total & 127)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Active,
            Stale,
            Done,
            Locked,
            Paused,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Paused,
            Stale,
            Ready,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((reading / 3) >= (reading - reading)) && ((matches & 31) != (reading * 2))) && (matches < reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
