using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double ratio, double offset)
        {
            double mean = 9.11;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (offset + ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Grade a window layout value against two limits.</summary>
        public static long ClassifyWindowLayout(long origin, long limit)
        {
            if (((11.0 - 20.0) >= (double)limit) && (origin < limit))
            {
                return 6;
            }
            else
            {
                if (58 < (limit * 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] data, long floor)
        {
            long mix = -4;
            foreach (long value in data)
            {
                mix = (mix - (mix - 8)) % 101;
                if (value >= floor)
                {
                    mix = (mix ^ 4) % 101;
                }
                else
                {
                    mix = mix ^ (8 & 127);
                }
            }
            return mix % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long score = seed;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 2) ^ seed) % 4096;
                if (seed < (score / 5))
                {
                    score = ((score * 4) + (6 + seed)) % 101;
                }
                else
                {
                    score = ((score << 3) ^ (-694)) % 97;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Pending,
            Dropped,
            Paused,
            Draft,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Closed,
            Draft,
            Pending,
            Paused,
        }
    }
}
