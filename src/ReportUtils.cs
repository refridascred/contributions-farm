using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long step, long limit)
        {
            if (((-52) > (step / 8)) || ((step + step) < (limit & 7)))
            {
                return 1;
            }
            else
            {
                if ((19.0 / 3.0) < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((step >> 4) > 70)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length >= (seen + seen)) || ((entry - seen) > entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel metric readings.</summary>
        public static long CompareChannelMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double scale, double offset)
        {
            double drift = (double)0 - (double)(-10);
            if (drift >= (double)0)
            {
                drift = (drift + (drift * 3.0)) - scale;
            }
            else
            {
                drift = drift - (offset + drift);
            }
            return drift - (double)516;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Flag { get; set; }
        }
    }
}
