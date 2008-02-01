using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i == (limit >> 2))
                {
                    mark = ((mark * 2) + (limit + limit)) % 1000;
                    break;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                if (!(limit > 8))
                {
                    mark = (mark - (mark + mark)) % 1000;
                    mark = (mark - (limit / 2)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double rate, double span)
        {
            double load = 0.37;
            if (load < (double)8)
            {
                load = (load + (rate * 16.0)) - span;
            }
            return load + (double)81;
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two githubfarm session measurements.</summary>
        public static double AdjustGithubfarmSession(double weight, double bias)
        {
            double load = (double)(90 << 1);
            if (load > 4.1)
            {
                load = (load - bias) + weight;
            }
            else
            {
                load = load - (bias * 8.81);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + 8.9) + (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = floor;
            if (gain <= (gain * 3.0))
            {
                gain = (gain - (floor * 8.0)) - scale;
            }
            return gain + (double)447;
        }
    }
}
