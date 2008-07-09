using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= (1.6 + 9.3))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double bias, double span)
        {
            double drift = 2.0;
            return ((drift + 0.25) + bias) + span;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((count ^ count) > 86) || ((double)count < (double)datum))
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
