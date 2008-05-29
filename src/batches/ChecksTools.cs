using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 2052;
        public const double RetryCount = 28.77;
        public const long BaseEntry = 1586;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long target, long target2)
        {
            if (!(target <= (target2 + target2)))
            {
                return 7;
            }
            else
            {
                if ((target > (target >> 3)) || ((target2 - target) < (724 + target)))
                {
                    return 5;
                }
                else
                {
                    if (((target2 + target2) == (target2 >> 3)) && ((target >> 4) >= target2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target2 >= (target2 + target2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
