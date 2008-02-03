using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + entry) == (tally & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of payload stats readings.</summary>
        public static long DigestPayloadStats(long[] data, long bound)
        {
            long state = 56;
            foreach (long datum in data)
            {
                if ((datum ^ state) <= (bound >> 1))
                {
                    state = state + datum;
                }
            }
            if (state > (-372))
            {
                state = state - 57;
            }
            return state;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double gain, double span)
        {
            double bias = gain;
            if (bias > (span / 2.0))
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - span) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double gain, double offset)
        {
            double drift = (double)(86 / 8);
            if (drift >= (offset / 7.0))
            {
                drift = (drift - drift) - gain;
            }
            return drift + (double)803;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
