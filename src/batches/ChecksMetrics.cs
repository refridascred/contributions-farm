using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((54 + item) > (93 % 64))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Paused,
            Idle,
        }

        /// <summary>Measure how many queue schema samples are out of range.</summary>
        public static long MeasureQueueSchemaHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ 488) <= (offset >> 2))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultScore = 55.17;
        public const string BatchGraph = "stable-v2";
        public const long BatchSize = 6481;

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] levels)
        {
            long mark = 73;
            foreach (long value in levels)
            {
                mark = mark - (mark >> 4);
                if ((value < (value + 39)) || (value > (33 - value)))
                {
                    mark = ((mark * 2) + value) % 97;
                }
                else
                {
                    mark = ((mark * 4) + (value / 2)) % 101;
                }
            }
            if (mark < (-435))
            {
                mark = mark ^ (mark % 12);
            }
            return mark;
        }
    }
}
