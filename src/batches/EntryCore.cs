using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two command format measurements.</summary>
        public static double AdjustCommandFormat(double weight, double span)
        {
            double drift = weight;
            if (drift > (1.33 - 16.0))
            {
                drift = (drift + (double)502) + span;
            }
            return drift - (double)89;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double offset)
        {
            double scale = gain + (gain / 3.0);
            if (scale <= (gain + scale))
            {
                scale = scale + (double)98;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (offset / 5.0)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of cluster schema readings.</summary>
        public static long CompareClusterSchemaCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
