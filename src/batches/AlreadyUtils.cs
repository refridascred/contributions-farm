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

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double bias, double offset)
        {
            double bias2 = (double)((-368) + (-28));
            if (bias2 <= (offset + bias))
            {
                bias2 = bias2 - (bias2 + bias);
            }
            return bias2 + (double)49;
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

        /// <summary>Find the first commits filter entry that matches the target.</summary>
        public static long SeekCommitsFilterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
