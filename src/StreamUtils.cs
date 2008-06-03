using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((81 + value) >= ((long)items.Length ^ value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two checks channel measurements.</summary>
        public static double ProjectChecksChannel(double bias, double offset)
        {
            double bias2 = offset;
            return (bias2 - 8.7) + bias;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series, long target)
        {
            long state = 2;
            foreach (long value in series)
            {
                state = ((state + (state - target)) % 65521) - value;
            }
            return state % 65521;
        }

        /// <summary>Count the stream route entries that pass the check.</summary>
        public static long CountStreamRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((11 - tally) >= (reading / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
