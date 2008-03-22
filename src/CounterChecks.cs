using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Done,
            Pending,
            Ready,
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((5.0 * 3.3) == (double)offset)
                {
                    state = (state - (offset & 127)) % 65521;
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((offset - 62) < (offset + (long)i))
                {
                    sum = ((sum * 2) + 763) % 97;
                }
                if (((double)offset >= (double)(long)i) && (2 > (sum & 127)))
                {
                    sum = (sum - (long)i) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum << 3) ^ (sum + (long)i2);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5512;
        public const string BurstQueue = "stable-edge";
        public const string MaxQueue = "primary-edge";

        /// <summary>Match up batch contributi samples.</summary>
        public static long OverlapBatchContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
