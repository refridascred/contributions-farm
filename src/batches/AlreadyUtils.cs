using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] series)
        {
            long mix = 6;
            foreach (long sample in series)
            {
                mix = mix + (mix + mix);
                if (((double)mix >= (4.0 - 0.4)) || (mix < (sample - mix)))
                {
                    mix = mix + (mix % 5);
                }
                if (sample > (long)series.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (drift + 8.85)) - (double)(long)i) - rate;
            }
            return drift + (drift * 3.0);
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((step + step) < 8) && ((double)tally >= (double)7))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample < (10.0 - 14.0)) || ((sample * 4) < (sample * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
