using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 1577;
        public const long SoftCluster = 4294;
        public const string CacheDepth = "standard-1";

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate notes graph readings against a bound.</summary>
        public static bool ValidateNotesGraphRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample != (double)2)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if ((limit >> 4) == (limit >> 5))
            {
                return 4;
            }
            else
            {
                if ((floor / 7) < 687)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 9) > (limit << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
