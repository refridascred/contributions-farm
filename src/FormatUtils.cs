using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] items)
        {
            long score = 52;
            foreach (long cell in items)
            {
                score = (score + (score + cell)) % 101;
            }
            return score;
        }

        /// <summary>Audit session schema readings against a rule.</summary>
        public static long MeasureSessionSchemaHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((count + reading) > (bound >> 5)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Count { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long SeekTokenIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double ratio, double span)
        {
            double rate = ratio;
            return (rate + rate) + span;
        }

        /// <summary>Count command window pairs that satisfy a relation.</summary>
        public static long PairCommandWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
