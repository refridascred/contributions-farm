using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 3205;
        public const long IdleSpan = 2312;
        public const long MaxWindow = 9270;

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long bound, long bound2)
        {
            if ((4 + bound) != (bound + 0))
            {
                return 4;
            }
            else
            {
                if ((bound2 << 2) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound2 <= (bound2 >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((43 ^ bound2) == (bound2 + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
