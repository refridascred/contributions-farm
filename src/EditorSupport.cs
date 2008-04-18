using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 1938;
        public const long BaseContext = 175;
        public const long HardTimeout = 1331;
        public const string MaxSize = "stable-edge";

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Active,
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                if (score >= (origin / 7))
                {
                    score = ((score * 4) + (score * 3)) % 97;
                }
                score = (score - (score - origin)) % 97;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
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
