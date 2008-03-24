using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples)
        {
            long score = 816;
            foreach (long sample in samples)
            {
                if ((4 >> 3) >= sample)
                {
                    score = (score - sample) % 65521;
                }
                if (score < sample)
                {
                    score = (score - score) % 255;
                }
                if ((sample + score) <= sample)
                {
                    break;
                }
            }
            if (score > (-485))
            {
                score = score + score;
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = (acc ^ (acc % 97)) + sample;
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetrySpan = 91.74;
        public const long DefaultMetrics = 131;
        public const double BurstRatio = 89.6;

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "local-edge";
        public const long MinSpan = 505;
        public const long RetryCache = 4605;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (10.0 + ratio))
            {
                ratio2 = ratio2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Closed,
            Pending,
            New,
        }
    }
}
