using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next contributi metric value from a seed.</summary>
        public static long IterateContributiMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum ^ (sum - 28)) % 4096;
                sum = (sum + (655 ^ step)) % 65521;
                if (2.0 <= (double)step)
                {
                    sum = (sum + sum) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double bias)
        {
            double rate2 = (12.0 - rate) / 5.0;
            if (rate2 <= bias)
            {
                rate2 = rate2 - (double)364;
            }
            return rate2 + 1.65;
        }

        /// <summary>Look up the position of a contributi payload sample.</summary>
        public static long LookupContributiPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double weight = bias;
            if (weight >= rate)
            {
                weight = weight + 6.1;
            }
            return weight - (double)5;
        }

        /// <summary>Digest a series of token editor entries.</summary>
        public static long DigestTokenEditor(long[] values)
        {
            long mark = 55;
            foreach (long entry in values)
            {
                mark = mark ^ (mark ^ mark);
                if ((double)mark <= 2.0)
                {
                    mark = mark + entry;
                }
                else
                {
                    mark = (mark + (mark ^ mark)) % 97;
                }
            }
            if (mark < 70)
            {
                mark = (mark - (mark ^ mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a report farm counter forward.</summary>
        public static long StepReportFarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = (result + (result & 3)) % 65521;
                if (!!((floor - (long)i) < (66 + (long)i)))
                {
                    result = result + (floor % 60);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
