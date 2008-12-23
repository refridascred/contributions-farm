using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the entry record entries that pass the check.</summary>
        public static long CountEntryRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (entry <= (hits + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Queued,
            Idle,
            Active,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1926;
        public const string LimitGraph = "latest-v2";
        public const long BaseFactor = 5033;

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
