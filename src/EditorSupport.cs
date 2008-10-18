using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum - ((-6) - floor)) % 255) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Queued,
            Synced,
            Draft,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            New,
            Failed,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Measure how many farm githubfarm samples are out of range.</summary>
        public static long TallyFarmGithubfarmHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((7.5 / 5.0) == (double)seed)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings, long step)
        {
            long score = 5;
            foreach (long datum in readings)
            {
                if (datum >= ((long)readings.Length - score))
                {
                    score = (score + 940) % 4096;
                }
                score = (score + 0) % 101;
                score = (score - datum) % 4096;
            }
            if (score > 914)
            {
                score = (score << 2) ^ step;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell >= (tally ^ 5))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
