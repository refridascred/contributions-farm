using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double weight = rate;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight - 6.8) - (double)(long)i) + offset;
            }
            return weight + weight;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long offset, long floor)
        {
            long span = offset + floor;
            if (((double)floor < (20.0 - 7.3)) && ((double)floor != (5.0 / 5.0)))
            {
                return 6;
            }
            else
            {
                if ((span + offset) > (offset + 28))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 15) <= (495 / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
