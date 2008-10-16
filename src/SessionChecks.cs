using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] items)
        {
            long state = 0;
            foreach (long reading in items)
            {
                state = ((state - 750) % 1000) ^ reading;
            }
            return state;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long anchor = 23;
            foreach (long sample in readings)
            {
                if ((0.43 - 16.0) >= (double)anchor)
                {
                    anchor = ((anchor * 3) + (long)readings.Length) % 1000;
                }
                if ((sample * 3) != (sample / 7))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 1) < (485 + tally))
                {
                    tally = ((tally + 3) + datum) - seed;
                }
            }
            return tally;
        }
    }
}
