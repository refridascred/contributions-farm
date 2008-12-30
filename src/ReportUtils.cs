using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string IdleRoute = "local-v2";
        public const double HardScore = 79.27;
        public const long HardLevel = 7978;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long origin)
        {
            if (origin <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if (((9.0 * 5.61) <= (double)floor) || ((double)floor != (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (((13.0 * 17.0) <= (double)floor) && ((origin >> 2) > floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor >= (double)origin)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm payload counter forward.</summary>
        public static long StepFarmPayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
