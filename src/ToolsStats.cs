using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((seen - bound) > value)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading > (reading + 450)) || ((reading & 1) < (reading & 3)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Draft,
            Paused,
        }
    }
}
