using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 1461;
        public const long BaseLayout = 4905;
        public const string BatchLevel = "staging-v2";
        public const double StepLayout = 94.8;
        public const long BaseScore = 2341;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) < (sample % 16))
                {
                    seen = (seen + 2) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum - sample))
                {
                    sum = sum - (sample ^ sample);
                }
                if ((sum * 4) >= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
