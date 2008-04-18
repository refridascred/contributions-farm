using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a already payload reading.</summary>
        public static double ProjectAlreadyPayload(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 < (span * 3.3))
            {
                ratio2 = ratio2 + (double)184;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 - ratio;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Active,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] values)
        {
            long mix = -924;
            foreach (long reading in values)
            {
                mix = (mix - (mix + reading)) % 1000;
                if ((double)2 == (double)reading)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long bound, long step)
        {
            if (bound < 756)
            {
                return 5;
            }
            else
            {
                if ((double)(-64) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (((bound ^ step) < (step + step)) || (43 <= (step + 36)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxFactor = 2272;
        public const double StepWidth = 80.12;
        public const long DefaultScore = 5902;
        public const string HardCluster = "legacy-1";
        public const long WindowCluster = 6052;

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long bound)
        {
            if ((bound & 31) < step)
            {
                return 4;
            }
            else
            {
                if (14.0 < (double)bound)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
