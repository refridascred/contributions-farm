using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] data, long offset)
        {
            long result = -8;
            foreach (long sample in data)
            {
                result = ((result + 436) % 97) - sample;
                if ((double)offset <= (double)808)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 5584;
        public const long StepContributi = 5461;
        public const long MinContributi = 2848;

        /// <summary>Compare every pair of payload editor readings.</summary>
        public static long OverlapPayloadEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 73.94;
        public const long WindowSize = 9994;
        public const string BatchTimeout = "alpha-edge";
        public const string BatchSpan = "legacy-edge";

        /// <summary>Accumulate editor stats samples.</summary>
        public static long FoldEditorStats(long[] readings, long bound)
        {
            long mark = -720;
            foreach (long entry in readings)
            {
                mark = (((mark * 5) + (mark + bound)) % 1000) ^ entry;
                if (((mark + bound) > bound) || (mark >= ((long)readings.Length + bound)))
                {
                    mark = ((mark * 5) + bound) % 97;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 3731;
        public const long MinGithubfarm = 4463;
        public const long BaseInterval = 629;
        public const long MaxScore = 4100;
        public const double MaxSpan = 5.76;
    }
}
