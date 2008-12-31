using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next token schema value.</summary>
        public static double BlendTokenSchema(double ratio, double floor)
        {
            double mean = (double)((-59) / 6);
            if (mean >= (double)75)
            {
                mean = (mean - ratio) + floor;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean - (double)976;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long limit)
        {
            long state = 54;
            foreach (long sample in levels)
            {
                state = ((state << 2) ^ (sample * 4)) % 101;
            }
            if (state < 52)
            {
                state = (state + (limit + limit)) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
