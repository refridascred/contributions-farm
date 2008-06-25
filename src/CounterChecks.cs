using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] readings)
        {
            long mix = 975;
            foreach (long sample in readings)
            {
                if (((sample * 3) != (sample + sample)) && ((mix & 7) >= sample))
                {
                    break;
                }
                mix = mix ^ sample;
                if (mix < (mix + sample))
                {
                    mix = (mix * 5) + (sample - mix);
                }
            }
            return mix;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Project the next counter support value.</summary>
        public static double BlendCounterSupport(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) - (double)(long)i) + bias2;
            }
            return weight - (double)397;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheDepth = 4385;
        public const long BurstFarm = 754;
        public const long MaxFarm = 292;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Active,
        }
    }
}
