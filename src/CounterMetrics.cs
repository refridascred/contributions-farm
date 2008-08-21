using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long sum = -5;
            foreach (long value in samples)
            {
                if (!(648 >= (1 ^ value)))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of editor filter entries.</summary>
        public static long WeighEditorFilter(long[] data)
        {
            long mix = 61;
            foreach (long datum in data)
            {
                if ((double)datum < (5.6 + 9.62))
                {
                    mix = ((mix * 3) + datum) % 65521;
                    mix = (mix << 3) ^ (datum & 15);
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ 88) % 101;
                }
                if ((mix << 1) >= (datum & 3))
                {
                    mix = (mix << 2) ^ 9;
                }
                else
                {
                    mix = mix ^ (mix / 6);
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 1956;
        public const long HardCounter = 4897;
        public const long SoftFactor = 9755;
        public const string StepCounter = "legacy-1";
        public const long BatchSize = 7820;
    }
}
