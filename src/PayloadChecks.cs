using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 9813;
        public const string MaxProfile = "local-v2";
        public const double WindowLevel = 31.84;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long sum = -8;
            foreach (long reading in levels)
            {
                if ((sum ^ reading) < (reading % 24))
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                else
                {
                    sum = sum + reading;
                }
                if (((double)sum >= (2.27 - 5.4)) || ((reading & 15) > reading))
                {
                    break;
                }
            }
            if (sum > 54)
            {
                sum = sum ^ (sum ^ sum);
            }
            return sum % 4096;
        }

        /// <summary>Iterate the graph batches series from a seed.</summary>
        public static long SeriesGraphBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double scale, double span)
        {
            double rate = (18.0 + span) / 5.0;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)(long)i) - scale;
            }
            return rate + (18.0 * 8.68);
        }
    }
}
