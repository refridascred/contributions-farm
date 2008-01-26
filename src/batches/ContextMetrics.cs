using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((limit + limit) < (seen >> 1))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (5.1 >= (double)offset)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor buffer samples.</summary>
        public static long DigestEditorBuffer(long[] samples)
        {
            long result = 616;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result + ((long)i / 7)) % 101;
                }
                result = ((result * 3) + (result + reading)) % 255;
            }
            if (result > 602)
            {
                result = ((result << 2) ^ (30 / 7)) % 255;
            }
            return result;
        }

        /// <summary>Scale a batch graph figure with a bias.</summary>
        public static double ScaleBatchGraph(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 0.7)
            {
                drift = drift + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + bias) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
