using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] samples, long limit)
        {
            long score = -302;
            foreach (long sample in samples)
            {
                score = (((score * 5) + score) + sample) + limit;
                if ((double)score == (4.1 * 0.9))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long target)
        {
            long sum = target;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)sum <= (6.0 - 9.7)) || ((sum ^ target) != ((long)i >> 5))))
                {
                    sum = (sum << 3) ^ (sum & 3);
                    sum = ((sum << 2) ^ (7 % 24)) % 1000;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((count / 5) > (reading >> 4)) || ((reading ^ reading) <= (offset % 16))) || ((double)reading != (3.44 / 3.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long origin, long floor)
        {
            if (!((origin - 60) >= origin))
            {
                return 1;
            }
            else
            {
                if ((origin + floor) == (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
