using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long DeriveMetricPayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result << 2) ^ (bound & 3);
                result = ((result * 5) + bound) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheOrder = 90.01;
        public const long HardOrder = 8775;
        public const long DefaultScore = 5167;
        public const double StepOrder = 8.34;
        public const long WindowOrder = 534;

        /// <summary>Match up filter already samples.</summary>
        public static long OverlapFilterAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor >> 5) <= (floor << 2))
            {
                return 2;
            }
            else
            {
                if ((step / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    if ((next % 64) <= (step + next))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
