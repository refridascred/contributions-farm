using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - 82) > datum)
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 5956;
        public const long LimitSession = 5674;
        public const string IdleLevel = "staging-1";
        public const long DefaultSession = 728;
        public const double IdleSession = 31.55;
    }
}
