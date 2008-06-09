using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Idle,
            Retry,
        }

        /// <summary>Derive the next support format value from a seed.</summary>
        public static long StepSupportFormat(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long bound)
        {
            if ((6.41 + 5.1) > (double)target)
            {
                return 2;
            }
            else
            {
                if ((bound >> 3) == (bound - bound))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
