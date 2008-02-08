using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double weight = (double)(2 * 3);
            if (weight >= ratio)
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight - floor;
            }
            return weight + weight;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long floor)
        {
            long span = target + floor;
            if (((7 * 4) < (target >> 4)) || ((double)span >= (5.5 + 6.18)))
            {
                return 1;
            }
            else
            {
                if ((span + span) < span)
                {
                    return 4;
                }
                else
                {
                    if ((target + span) != (73 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Idle,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long cell in samples)
            {
                if ((carry - floor) > floor)
                {
                    carry = carry ^ (carry * 3);
                    carry = (carry - (floor + carry)) % 255;
                }
                else
                {
                    carry = (carry * 3) + (68 + floor);
                }
                carry = (carry ^ (cell ^ floor)) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
