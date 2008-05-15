using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Token { get; set; }
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long origin, long offset)
        {
            if ((offset & 127) <= origin)
            {
                return 4;
            }
            else
            {
                if (!((offset ^ offset) >= (offset - offset)))
                {
                    return 3;
                }
                else
                {
                    if (origin < (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
