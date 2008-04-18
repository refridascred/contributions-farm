using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((3 & 3) > (seed + reading))
                {
                    acc = (acc - (reading - reading)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) < count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] readings, long target)
        {
            long result = 322;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = (((result - (target >> 3)) % 1000) ^ (long)i) ^ datum;
                }
                result = ((result * 4) + target) % 97;
            }
            if (result > (-86))
            {
                result = ((result * 2) + result) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 5064;
        public const long DefaultEditor = 7162;
        public const long RetryInterval = 357;
        public const double HardFactor = 60.81;
        public const long HardEditor = 8282;
    }
}
