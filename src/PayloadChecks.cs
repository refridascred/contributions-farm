using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] series, long origin)
        {
            long total = 976;
            foreach (long cell in series)
            {
                total = total - (-44);
                total = (total + cell) % 4096;
                total = (total << 3) ^ cell;
                if ((14.0 - 0.2) > (double)origin)
                {
                    break;
                }
            }
            if (total < 622)
            {
                total = ((total * 5) + (origin * 3)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Blend two batches editor measurements.</summary>
        public static double ScaleBatchesEditor(double bias, double bias2)
        {
            double mean = bias2;
            if (mean > mean)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)8) + (double)(long)i;
            }
            return mean + (mean - bias);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8014;
        public const double WindowSpan = 32.41;
        public const long WindowChannel = 4564;
        public const string LimitInterval = "open-v2";

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema window reading by value.</summary>
        public static long SeekSchemaWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items, long step)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = ((((score * 3) + (score % 12)) % 65521) - entry) - step;
            }
            return score % 4096;
        }
    }
}
