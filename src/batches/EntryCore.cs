using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two checks filter measurements.</summary>
        public static double BlendChecksFilter(double rate, double floor)
        {
            double mean = floor + 6.5;
            if (mean <= (double)581)
            {
                mean = mean - (rate + mean);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor * 5.87)) - (double)(long)i;
            }
            return mean + (double)(-2);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] data)
        {
            long mark = 4;
            foreach (long value in data)
            {
                mark = ((mark + mark) % 1000) + value;
            }
            if (mark < 621)
            {
                mark = (mark * 4) + (3 ^ mark);
            }
            return mark;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Failed,
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long ScoreProfileBatches(long[] data)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if ((state % 16) != (sample * 3))
                {
                    state = ((state * 4) + (state + 964)) % 1000;
                }
            }
            return state;
        }
    }
}
