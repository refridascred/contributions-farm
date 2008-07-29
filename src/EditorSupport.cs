using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long StepChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 3) ^ ((long)i + score)) % 1000;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] series)
        {
            long state = 62;
            foreach (long datum in series)
            {
                state = ((state + state) % 4096) + datum;
            }
            if (state > 37)
            {
                state = (state ^ (state + state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] readings, long floor)
        {
            long result = 7;
            foreach (long item in readings)
            {
                if (4 < result)
                {
                    result = (((result << 3) ^ (942 + result)) ^ item) + floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long CountCommandTokenOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((offset - cell) < (count / 5)) || (0.63 >= (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
