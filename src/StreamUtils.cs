using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (85 >= bound)
            {
                return 3;
            }
            else
            {
                if (((origin2 << 2) >= bound) && (bound <= (origin - 734)))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 + bound) != (bound / 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >> 2) == (origin + origin2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long TallyMetricStreamOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) != (sample * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long step, long limit)
        {
            if (11 < (limit & 1))
            {
                return 5;
            }
            else
            {
                if ((limit + step) <= step)
                {
                    return 6;
                }
                else
                {
                    if ((2.0 * 12.0) > (double)limit)
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

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Draft,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Dropped,
            Locked,
        }
    }
}
