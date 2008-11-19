using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate format commits samples.</summary>
        public static long ScoreFormatCommits(long[] readings, long target)
        {
            long mix = 429;
            foreach (long reading in readings)
            {
                mix = mix - (target >> 5);
                if (reading < (mix / 9))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a channel notes sample.</summary>
        public static long FindChannelNotesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((count - 9) == (1 % 24)) || ((double)count <= (1.58 / 4.0))) || ((44 - sample) > sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next session report value.</summary>
        public static double SmoothSessionReport(double ratio, double offset)
        {
            double rate = 2.27 / 7.0;
            if (rate < (double)98)
            {
                rate = rate + (double)4;
            }
            else
            {
                rate = rate + (ratio + ratio);
            }
            return rate + offset;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen << 3) < (61 >> 4))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
