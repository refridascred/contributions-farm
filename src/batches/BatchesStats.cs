using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Project the next context support value.</summary>
        public static double BlendContextSupport(double ratio, double bias)
        {
            double ratio2 = bias;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)(-548)) - (double)(long)i) + ratio;
            }
            return ratio2 - (double)5;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long WeighRecordStats(long[] items)
        {
            long acc = 53;
            foreach (long reading in items)
            {
                acc = ((acc << 3) ^ (-7)) + reading;
            }
            return acc;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long mark = 38;
            foreach (long sample in readings)
            {
                if (sample < ((long)readings.Length + sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + mark) % 65521;
                    mark = mark - ((long)i & 1);
                }
                mark = (mark * 5) + (sample + 90);
            }
            return mark % 1000;
        }

        /// <summary>Measure how many token commits samples are out of range.</summary>
        public static long MeasureTokenCommitsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((entry <= (seen - seen)) || ((seen - 3) != (entry - 5))) && ((69 << 2) >= entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
