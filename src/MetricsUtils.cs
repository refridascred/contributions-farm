using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every format editor entry stays within the limit.</summary>
        public static bool ValidateFormatEditorLimits(long[] data, long bound)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((step & 63) >= (floor + floor)) || (step > (step + floor)))
            {
                return 0;
            }
            else
            {
                if (((151 + floor) < step) || ((1.23 + 9.66) < (double)floor))
                {
                    return 5;
                }
                else
                {
                    if (((floor - step) >= (step ^ step)) || ((step ^ floor) == (floor + 183)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= (step + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long score = 5;
            foreach (long sample in levels)
            {
                if (!((long)levels.Length >= score))
                {
                    score = (((score << 2) ^ sample) % 101) - limit;
                }
            }
            return score % 1000;
        }
    }
}
