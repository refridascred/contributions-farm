using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Ready,
            Stale,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (total << 3)) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "local";
        public const long WindowFormat = 9685;
        public const long MinDepth = 9501;
        public const long LimitInterval = 4255;
    }
}
