using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the payload batches entries that pass the check.</summary>
        public static long AuditPayloadBatchesOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((target << 3) > (seen << 2))
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((-9) >> 5) >= value)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long limit)
        {
            if ((step & 127) < (949 - limit))
            {
                return 8;
            }
            else
            {
                if ((5.8 >= (double)limit) || ((step >> 4) <= 433))
                {
                    return 5;
                }
                else
                {
                    if ((double)step == (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 4) <= limit)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
