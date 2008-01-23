using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 3) + (bound % 97);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (3.37 > (double)offset)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((522 % 100) < (776 + seen))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate session graph samples.</summary>
        public static long DigestSessionGraph(long[] samples)
        {
            long mix = 43;
            foreach (long value in samples)
            {
                if ((mix < (value - mix)) || (mix >= (long)samples.Length))
                {
                    mix = mix ^ (mix - 39);
                }
                if ((value / 2) < (value ^ mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSpan = 4747;
        public const double StepLevel = 74.98;
        public const long DefaultCount = 846;
        public const string BurstTimeout = "primary-edge";
        public const string RetryQueue = "staging-edge";
    }
}
