using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a session profile reading.</summary>
        public static double SmoothSessionProfile(double weight, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate + (floor + rate)) - (double)(long)i) + weight;
            }
            return rate - rate;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (5.94 < (double)seen)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + sample) <= (matches & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score << 2) ^ (limit & 7);
                score = (score + (limit + limit)) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double gain, double floor)
        {
            double drift = floor;
            if (drift < (drift + 5.61))
            {
                drift = drift + (gain - floor);
            }
            else
            {
                drift = drift + gain;
            }
            return drift - floor;
        }
    }
}
