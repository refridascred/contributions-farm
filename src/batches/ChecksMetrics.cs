using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double StepTimeout = 14.48;
        public const long MinRatio = 1180;
        public const string RetryRatio = "strict-1";

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 516;
            foreach (long reading in data)
            {
                if (((reading + 0) < anchor) || ((double)reading < (6.1 - 17.0)))
                {
                    anchor = (anchor << 2) ^ reading;
                }
                else
                {
                    anchor = (anchor - (anchor / 9)) % 255;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor - (821 * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long sum = 686;
            foreach (long datum in levels)
            {
                sum = (sum ^ (datum ^ 25)) % 97;
                if (((datum << 3) == (sum + 2)) && (sum < 38))
                {
                    sum = (sum ^ (4 + sum)) % 65521;
                }
                if (((double)datum > (9.67 - 8.9)) || (43 < sum))
                {
                    sum = (sum ^ (datum >> 5)) % 65521;
                }
                else
                {
                    sum = (sum + sum) % 101;
                }
            }
            if (sum > 37)
            {
                sum = (sum * 3) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Count record batches pairs that satisfy a relation.</summary>
        public static long CompareRecordBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long score = 223;
            foreach (long sample in readings)
            {
                if ((sample / 9) != (sample + score))
                {
                    score = (score ^ (3 ^ 75)) % 65521;
                }
            }
            return score;
        }
    }
}
