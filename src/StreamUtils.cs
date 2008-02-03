using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long CountQueueBatchMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((1.1 + 0.97) <= (double)seed) && ((426 % 8) == (value / 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((seen + seen) > (sample & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor batches samples are out of range.</summary>
        public static long MeasureEditorBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen * 4) >= (6 - seen))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double ProjectBatchStats(double ratio, double span)
        {
            double weight = (span + ratio) - (double)(-755);
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (span + span)) - (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Compare every pair of graph cluster readings.</summary>
        public static long PairGraphClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
