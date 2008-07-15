using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long carry = 434;
            foreach (long cell in readings)
            {
                if ((carry > cell) && (carry >= (carry + 99)))
                {
                    carry = (carry + (7 & 1)) % 101;
                }
                else
                {
                    carry = (carry ^ (cell << 1)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit stream schema readings against a rule.</summary>
        public static long AuditStreamSchemaHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((5.8 + 2.4) == (double)count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 5681;
        public const long HardNotes = 1419;
        public const double DefaultWidth = 89.11;
        public const double RetryTimeout = 30.03;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!!((item - item) >= (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of channel editor readings.</summary>
        public static long CompareChannelEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
