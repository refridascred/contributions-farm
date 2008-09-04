using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long sum = -50;
            foreach (long value in series)
            {
                if (sum <= (sum + value))
                {
                    sum = (sum + (value + sum)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum ^ 78)) % 101;
                }
            }
            if (sum > 9)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((tally > (reading ^ tally)) || ((333 >> 2) <= (reading % 5))))
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series, long seed)
        {
            long mix = 246;
            foreach (long sample in series)
            {
                mix = (mix + (seed & 1)) % 65521;
                if ((7.53 + 1.0) <= (double)sample)
                {
                    mix = mix ^ (mix >> 5);
                }
                if (sample < (seed ^ mix))
                {
                    break;
                }
            }
            if (mix < 38)
            {
                mix = mix ^ (seed - mix);
            }
            return mix;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if (((sample / 8) <= (mark + sample)) || ((7.92 + 3.47) <= (double)(long)items.Length))
                {
                    mark = ((mark << 2) ^ ((long)items.Length * 5)) % 4096;
                }
                else
                {
                    mark = mark + (sample - (long)items.Length);
                }
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark - (long)i) % 255;
                }
                if ((mark >= (mark - sample)) && (mark <= (sample - sample)))
                {
                    mark = (mark ^ sample) % 255;
                }
                if ((double)mark < 9.0)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
