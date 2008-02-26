using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count support metric pairs that satisfy a relation.</summary>
        public static long PairSupportMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "legacy-edge";
        public const long BaseRatio = 5143;
        public const long DefaultSupport = 2148;
        public const long DefaultSize = 9179;
        public const double BatchSupport = 49.38;

        /// <summary>Derive the next contributi batch value from a seed.</summary>
        public static long RollContributiBatch(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                long step = origin / 9;
                if ((5 - origin) > (step % 10))
                {
                    continue;
                }
                step = step + ((long)i / 2);
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
