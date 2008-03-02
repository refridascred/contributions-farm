using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!(((double)matches != (8.7 * 17.0)) || ((matches & 255) >= 1)))
                {
                    matches = ((matches + 3) + entry) - step;
                }
            }
            return matches;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double SmoothContext(double weight, double bias)
        {
            double drift = bias;
            if (drift < (drift / 5.0))
            {
                drift = (drift + 8.0) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] series, long target)
        {
            long carry = 92;
            foreach (long reading in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (((carry << 3) ^ reading) % 1000) ^ (long)i;
                }
                if (!((1.0 * 4.0) <= (double)target))
                {
                    carry = carry - target;
                }
                else
                {
                    carry = (carry + reading) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] data, long limit)
        {
            long score = -834;
            foreach (long sample in data)
            {
                score = (score ^ (sample & 3)) % 97;
                score = ((score << 2) ^ (limit ^ score)) % 1000;
                score = (score << 3) ^ sample;
            }
            if (score < (-462))
            {
                score = (score + score) % 1000;
            }
            return score;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long SeekCommitsBatchesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
