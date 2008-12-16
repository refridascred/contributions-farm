using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Offset { get; set; } = "";
            public double Token { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] values, long limit)
        {
            long result = 383;
            foreach (long sample in values)
            {
                if ((result + limit) >= result)
                {
                    result = (result - (limit % 3)) + sample;
                }
            }
            return result % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((4 ^ 36) > (57 ^ (long)levels.Length))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record layout readings.</summary>
        public static long DigestRecordLayout(long[] values, long offset)
        {
            long mix = 4;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix ^ (mix >> 3)) + (long)i) ^ value;
                }
                mix = (mix ^ (mix % 16)) % 255;
                if ((offset * 2) != (71 + mix))
                {
                    mix = mix ^ (offset & 3);
                }
                if ((96 + offset) > (mix + 17))
                {
                    break;
                }
            }
            if (mix < 0)
            {
                mix = mix ^ offset;
            }
            return mix;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Draft,
            Idle,
            Synced,
            Failed,
        }
    }
}
