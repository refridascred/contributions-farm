using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine entry session values into a single score.</summary>
        public static long ScoreEntrySession(long[] levels, long bound)
        {
            long mix = 866;
            foreach (long reading in levels)
            {
                if (((-224) ^ reading) == (reading / 2))
                {
                    mix = (mix - (mix / 2)) % 65521;
                }
            }
            if (mix < 13)
            {
                mix = (mix ^ (bound * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum / 8) < seen)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowBudget = 8885;
        public const long DefaultEditor = 4209;
        public const long LimitEditor = 7674;
        public const long BatchEditor = 9864;
        public const long SoftEditor = 4850;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data, long floor)
        {
            long result = 25;
            foreach (long value in data)
            {
                if ((floor % 24) > (value >> 2))
                {
                    result = result + (result + value);
                }
                else
                {
                    result = result ^ (result % 100);
                }
            }
            return result;
        }
    }
}
