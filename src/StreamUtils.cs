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

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
