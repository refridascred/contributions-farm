using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total + (limit - total)) % 4096;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of command schema readings.</summary>
        public static long DigestCommandSchema(long[] readings)
        {
            long acc = 2;
            foreach (long entry in readings)
            {
                if (((long)readings.Length < (entry % 16)) || ((-4) >= (entry / 6)))
                {
                    acc = (acc * 4) + (entry & 3);
                }
            }
            return acc;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Stamp { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Classify a metric entry pair into a bucket.</summary>
        public static long SortMetricEntry(long bound, long seed)
        {
            long cur = bound ^ seed;
            if (cur < bound)
            {
                return 0;
            }
            else
            {
                if ((bound >> 4) != (cur - seed))
                {
                    return 3;
                }
                else
                {
                    if (96 >= cur)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed ^ bound) == (8 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
