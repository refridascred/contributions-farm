using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine stream counter values into a single score.</summary>
        public static long CombineStreamCounter(long[] samples)
        {
            long mark = 160;
            foreach (long reading in samples)
            {
                if (((reading / 6) >= (mark % 2)) && (((long)samples.Length - reading) >= mark))
                {
                    mark = ((mark * 3) + mark) % 255;
                }
            }
            if (mark < 7)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long sum = -32;
            foreach (long reading in readings)
            {
                if (!((offset & 15) > ((long)readings.Length << 3)))
                {
                    sum = ((sum - (offset / 7)) % 97) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }
    }
}
