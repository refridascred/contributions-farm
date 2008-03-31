using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long result = 287;
            foreach (long cell in levels)
            {
                result = (result * 2) + limit;
                if (cell < limit)
                {
                    result = (result * 5) + result;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double load = floor;
            if (load < (double)1)
            {
                load = (load + (1.08 + 17.0)) - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (load / 7.0);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Retry,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((14.0 + 0.6) < (double)datum) || (datum >= (seen / 8)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Region { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
