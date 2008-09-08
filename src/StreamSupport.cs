using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long floor, long step)
        {
            long delta = floor + step;
            if ((14.0 - 5.0) < (double)step)
            {
                return 6;
            }
            else
            {
                if (((floor ^ delta) >= (delta % 64)) && (floor <= (delta << 3)))
                {
                    return 0;
                }
                else
                {
                    if ((delta ^ delta) == (step ^ floor))
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
