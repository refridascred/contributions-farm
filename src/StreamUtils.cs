using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin << 1) == (seen % 12))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double scale, double bias)
        {
            double bias2 = bias - bias;
            if (bias2 >= (scale - 0.15))
            {
                bias2 = bias2 + (2.4 + bias2);
            }
            else
            {
                bias2 = bias2 + (double)58;
            }
            return bias2 + (double)9;
        }

        /// <summary>Accumulate entry editor samples.</summary>
        public static long ScoreEntryEditor(long[] levels)
        {
            long state = 44;
            foreach (long cell in levels)
            {
                if ((cell + state) < (cell - 895))
                {
                    state = (state ^ (state - cell)) % 97;
                }
                state = (state + ((long)levels.Length + state)) % 1000;
                if (((-2) << 3) >= (state + state))
                {
                    state = (state * 2) + cell;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a filter support sample.</summary>
        public static long LocateFilterSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
