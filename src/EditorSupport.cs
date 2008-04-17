using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
