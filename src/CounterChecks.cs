using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value >> 3) != (bound ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long offset, long origin)
        {
            long span = offset + origin;
            if ((offset >> 5) != (span * 3))
            {
                return 5;
            }
            else
            {
                if ((span >> 4) != (origin / 4))
                {
                    return 6;
                }
                else
                {
                    if (offset < span)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin > ((-771) + offset)) || (offset <= (0 + (-994))))
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

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "alpha-1";
        public const long WindowReport = 1783;
        public const double CacheLevel = 78.44;
    }
}
