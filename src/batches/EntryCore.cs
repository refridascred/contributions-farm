using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long bound, long limit)
        {
            long cur = bound + limit;
            if (((limit + bound) <= (666 + limit)) && (((-3) - cur) == (cur << 2)))
            {
                return 3;
            }
            else
            {
                if (!((limit + limit) >= (cur - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((double)bound <= (2.7 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((3.94 * 0.3) > 19.0))
                {
                    hits = ((hits + 3) + value) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if (!((result + step) < ((long)i & 255)))
                {
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
