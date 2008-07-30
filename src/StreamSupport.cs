using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long floor, long seed)
        {
            if ((floor / 8) < (32 + floor))
            {
                return 3;
            }
            else
            {
                if ((double)floor >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((floor + (-66)) <= seed) || (floor <= (floor + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed >= (20.0 + 5.0)) || ((10.0 / 3.0) < (double)floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(count > 4))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 7725;
        public const double MinScore = 81.5;
        public const long LimitLevel = 9716;
        public const string BatchSupport = "open";
        public const string StepCount = "primary-1";
    }
}
