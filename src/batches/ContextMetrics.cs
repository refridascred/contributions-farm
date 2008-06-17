using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a support cache reading.</summary>
        public static double SmoothSupportCache(double gain, double floor)
        {
            double gain2 = (double)(862 ^ 194);
            if (gain2 > gain)
            {
                gain2 = gain2 + floor;
            }
            else
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + (double)9) - (double)(long)i;
            }
            return gain2 - (floor / 4.0);
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long state = 699;
            foreach (long datum in data)
            {
                if (((74 - state) <= (state % 2)) && ((double)datum >= (5.1 - 9.0)))
                {
                    state = (state + (state + datum)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state - offset);
                }
            }
            if (state > 6)
            {
                state = state ^ 248;
            }
            return state;
        }

        /// <summary>Count the report buffer entries that pass the check.</summary>
        public static long AuditReportBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)matches < 4.0))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
