using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Synced,
            Done,
            Failed,
            Locked,
        }

        /// <summary>Accumulate graph metric samples.</summary>
        public static long CombineGraphMetric(long[] data)
        {
            long score = 75;
            foreach (long reading in data)
            {
                if (((reading >> 1) <= (6 - score)) && ((reading / 8) >= score))
                {
                    score = (score << 3) ^ (84 - (-7));
                    score = ((score * 3) + (reading + reading)) % 101;
                }
                else
                {
                    score = score + (score << 1);
                }
                score = score + (reading + score);
                if (score < (reading + score))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score - score) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mix = -72;
            foreach (long datum in readings)
            {
                if (datum >= (16 + 9))
                {
                    mix = (mix * 5) + (datum & 15);
                }
            }
            return mix;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((3.3 > (double)seen) || ((16.0 - 5.87) >= (double)reading)) && !((seen << 3) != ((long)levels.Length + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 53.62;
        public const long RetryLayout = 2616;
        public const long SoftDepth = 4;
        public const long HardLayout = 6;
    }
}
