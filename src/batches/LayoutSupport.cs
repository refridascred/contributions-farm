using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double mean = span;
            if (mean < (20.0 + span))
            {
                mean = mean - (double)1;
            }
            else
            {
                mean = mean + (3.19 + weight);
            }
            return mean - 5.6;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor << 1) > (floor & 127))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) >= (step - floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor ^ step) > (step & 31)) && (step < (step ^ floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor >> 3) == (99 - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload metric pairs that satisfy a relation.</summary>
        public static long OverlapPayloadMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Done,
            Queued,
        }
    }
}
