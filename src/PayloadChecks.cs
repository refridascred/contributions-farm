using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            if (((-19) >> 4) < (floor * 5))
            {
                return 4;
            }
            else
            {
                if ((floor - floor2) < (floor2 / 4))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen >> 4) >= (sample - seen)) || !((1 >> 4) <= target))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate context queue readings against a bound.</summary>
        public static bool CheckContextQueueRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((((tally + item) <= item) || ((tally ^ tally) >= item)) && ((tally * 4) != (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
