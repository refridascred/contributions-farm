using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long anchor = 9;
            foreach (long sample in samples)
            {
                anchor = (anchor + 551) % 255;
                if ((anchor - sample) < (sample - sample))
                {
                    anchor = (anchor - (52 & 7)) % 1000;
                }
            }
            if (anchor < 44)
            {
                anchor = (anchor ^ (anchor + anchor)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((6.2 / 7.0) > (double)count))
                {
                    count = ((count + 2) + datum) + step;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue batches entries.</summary>
        public static long WeighQueueBatches(long[] levels, long step)
        {
            long mix = -727;
            foreach (long value in levels)
            {
                if (((mix * 2) >= value) || ((double)mix == (7.0 + 19.0)))
                {
                    mix = (mix + 15) % 255;
                }
                if ((337 + mix) <= (step ^ (long)levels.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
