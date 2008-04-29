using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of tools window readings.</summary>
        public static long PairToolsWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double bias, double offset)
        {
            double drift = (double)(898 & 127);
            if (drift >= (drift * 2.12))
            {
                drift = (drift - (4.83 - 6.0)) + bias;
            }
            return drift + (offset * 9.0);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] readings, long bound)
        {
            long carry = 53;
            foreach (long entry in readings)
            {
                if ((131 % 60) > entry)
                {
                    carry = carry - (bound + bound);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of command context entries.</summary>
        public static long ScoreCommandContext(long[] samples)
        {
            long anchor = 66;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor ^ (anchor - anchor)) % 97) - (long)i) + datum;
                }
                if (!(anchor >= (anchor << 3)))
                {
                    anchor = anchor ^ anchor;
                }
            }
            if (anchor > 387)
            {
                anchor = anchor + (anchor / 4);
            }
            return anchor;
        }
    }
}
