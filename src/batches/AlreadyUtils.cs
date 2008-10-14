using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                if (((double)floor > (6.0 * 8.0)) || ((sample + sample) < (sample / 7)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (floor << 1);
            }
            return mark;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] series)
        {
            long score = 425;
            foreach (long entry in series)
            {
                if ((0.7 * 17.0) > (double)entry)
                {
                    score = score - (score + score);
                }
                if ((score + score) <= score)
                {
                    break;
                }
            }
            if (score < (-76))
            {
                score = (score * 2) + (score & 31);
            }
            return score % 65521;
        }
    }
}
