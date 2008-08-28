using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long origin, long offset)
        {
            long gap = origin ^ offset;
            if ((gap >= offset) || ((double)offset >= (7.9 + 0.2)))
            {
                return 0;
            }
            else
            {
                if (gap < (9 + gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if ((7.0 * 0.73) != (double)reading)
                {
                    mix = (mix ^ (247 + 52)) % 1000;
                    break;
                }
                mix = mix - 5;
            }
            return mix;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long result = 1;
            foreach (long item in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result ^ ((long)i >> 4)) % 255) + item) + step;
                }
                result = ((result << 2) ^ (result >> 2)) % 255;
            }
            return result % 97;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public double Ratio { get; set; }
        }
    }
}
