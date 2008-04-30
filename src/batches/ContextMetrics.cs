using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] samples, long step)
        {
            long mark = -1;
            foreach (long value in samples)
            {
                if ((mark / 2) > step)
                {
                    mark = (mark + (step + value)) % 101;
                    mark = (mark * 2) + (mark - value);
                }
                if (value >= (mark + mark))
                {
                    mark = mark ^ 251;
                }
                else
                {
                    mark = (mark + (long)samples.Length) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Look up the position of a cluster stream sample.</summary>
        public static long FindClusterStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long bound)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                if ((8.0 - 9.0) != (double)mix)
                {
                    mix = ((((mix << 3) ^ (mix << 3)) % 4096) ^ cell) - bound;
                }
                else
                {
                    mix = mix - (mix ^ 11);
                }
            }
            return mix % 4096;
        }
    }
}
