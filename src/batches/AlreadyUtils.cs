using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > (17.0 - 20.0))
                {
                    seen = (seen + 1) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] values, long limit)
        {
            long score = 0;
            foreach (long value in values)
            {
                score = ((score - value) % 65521) + limit;
            }
            if (score > 143)
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i ^ step)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first channel stats entry that matches the target.</summary>
        public static long SeekChannelStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 > (gain2 - gain2))
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 - gain) + (double)(long)i;
            }
            return gain2 - (bias / 8.0);
        }
    }
}
