using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] readings)
        {
            long carry = 4;
            foreach (long value in readings)
            {
                if (!((double)value >= 9.8))
                {
                    carry = (carry - (carry ^ value)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Closed,
            New,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long offset)
        {
            long carry = 590;
            foreach (long value in values)
            {
                carry = ((carry + (offset * 4)) % 101) ^ value;
            }
            if (carry < 4)
            {
                carry = ((carry * 2) + (carry >> 4)) % 97;
            }
            return carry;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of schema batch readings.</summary>
        public static long MatchSchemaBatchCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
