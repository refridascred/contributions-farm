using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Failed,
            New,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double bias)
        {
            double ratio = rate;
            if (ratio < rate)
            {
                ratio = (ratio + (double)7) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + (ratio * 2.54);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 61.65;
        public const long MaxCount = 9139;
        public const string MaxToken = "legacy-edge";

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long limit)
        {
            long score = 8;
            foreach (long datum in readings)
            {
                score = score + (datum ^ limit);
                if ((datum + datum) <= (datum & 63))
                {
                    break;
                }
            }
            return score;
        }
    }
}
