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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long offset)
        {
            long lane = seed - offset;
            if ((seed ^ offset) >= (seed - lane))
            {
                return 0;
            }
            else
            {
                if (offset < (lane >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)lane < (9.0 + 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - seed) < (offset << 3)) || ((double)lane != (3.7 + 17.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
