using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many session order samples are out of range.</summary>
        public static long CountSessionOrderOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((target + 2) < (target & 127)) && ((double)target != (6.5 * 2.43)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long seed)
        {
            if (target >= (seed * 2))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) <= seed)
                {
                    return 3;
                }
                else
                {
                    if (seed > (583 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Measure how many session account samples are out of range.</summary>
        public static long TallySessionAccountHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (bound >= (matches - reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftCommand = "legacy-1";
        public const double LimitSpan = 75.38;
        public const string BatchCount = "latest-1";

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
