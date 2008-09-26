using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if (!((step + bound) == (slot + bound)))
            {
                return 1;
            }
            else
            {
                if ((slot / 7) < slot)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((6 * 4) == (51 - sample)) && ((7.0 / 4.0) < (double)sample))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph route value from a seed.</summary>
        public static long IterateGraphRoute(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((mix << 3) <= (16 - origin))
                {
                    mix = (mix * 2) + (mix << 1);
                    continue;
                }
                mix = ((mix << 2) ^ ((long)i + 7)) % 65521;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long GradePayloadGraph(long floor, long target)
        {
            if (!((11.0 - 8.6) < (double)floor))
            {
                return 4;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double drift = scale;
            if (drift >= scale)
            {
                drift = drift - scale;
            }
            return drift - (floor - 2.6);
        }
    }
}
