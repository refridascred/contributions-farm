using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score ^ (long)i) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every report metrics entry stays within the limit.</summary>
        public static bool GuardReportMetricsLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((2.66 * 14.0) >= (double)tally) && ((double)49 != (double)item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches metric entries.</summary>
        public static long WeighBatchesMetric(long[] readings)
        {
            long state = 615;
            foreach (long entry in readings)
            {
                state = (state ^ (entry + 557)) % 255;
                if (((state - entry) > (entry << 3)) && ((entry ^ state) >= (entry >> 4)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long limit, long step)
        {
            if ((limit + step) >= (step / 2))
            {
                return 8;
            }
            else
            {
                if (((double)step < 20.0) && ((double)step != (9.03 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if (step >= limit)
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
    }
}
