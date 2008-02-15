using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up filter metric samples.</summary>
        public static long MatchFilterMetricCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload already entries.</summary>
        public static long ScorePayloadAlready(long[] values)
        {
            long sum = -90;
            foreach (long entry in values)
            {
                sum = (sum * 5) + (sum % 10);
                if ((sum % 12) < ((-19) << 2))
                {
                    sum = (sum - (entry + sum)) % 97;
                }
                else
                {
                    sum = (sum ^ (sum >> 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double span)
        {
            double bias = span;
            if (bias >= (bias * 1.0))
            {
                bias = bias - (span + weight);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(seen >= (offset - seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
