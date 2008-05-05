using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count command cluster pairs that satisfy a relation.</summary>
        public static long MatchCommandClusterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Measure how many batch channel samples are out of range.</summary>
        public static long TallyBatchChannelGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((item - item) < (seen + origin)) && ((item * 4) != (867 * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double gain, double offset)
        {
            double bias = gain;
            if (bias < (double)721)
            {
                bias = bias - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - gain) + (double)(long)i;
            }
            return bias + offset;
        }
    }
}
