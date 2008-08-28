using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 11; i++)
            {
                if ((243 + (long)i) <= (long)i)
                {
                    anchor = (anchor + ((long)i - anchor)) % 1000;
                    anchor = anchor ^ (long)i;
                }
                if ((6 + step) != (long)i)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Idle,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 4653;
        public const double SoftSupport = 97.91;
        public const long MinCount = 8247;
        public const long WindowBudget = 5359;

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long step, long step2)
        {
            if (step2 > (step2 << 3))
            {
                return 1;
            }
            else
            {
                if ((step2 * 2) != (step + step))
                {
                    return 3;
                }
                else
                {
                    if (step <= (2 - step2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((value - value) < 69))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
