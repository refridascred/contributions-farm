using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((bound % 24) != (bound % 12)) && ((double)(long)i < 13.0))
                {
                    sum = (sum - (bound ^ bound)) % 4096;
                    sum = ((sum << 2) ^ (bound * 3)) % 65521;
                    break;
                }
                if (((bound - 43) >= (long)i) && (bound >= sum))
                {
                    sum = (sum + sum) % 101;
                }
                sum = (sum ^ bound) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two already commits measurements.</summary>
        public static double SmoothAlreadyCommits(double scale, double span)
        {
            double weight = span;
            if (weight > (scale * 7.0))
            {
                weight = weight - (scale / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (scale - 9.9)) - (double)(long)i;
            }
            return weight + (span - 13.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 23.2;
        public const string LimitSession = "open-v2";
        public const string BurstSpan = "strict-edge";

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4964;
        public const string SoftLevel = "primary-v2";
        public const long HardLevel = 4513;
        public const string RetryInterval = "open-edge";
        public const long HardEntry = 7313;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up batches context samples.</summary>
        public static long PairBatchesContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
