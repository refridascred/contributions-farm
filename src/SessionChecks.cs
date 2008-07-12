using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long TallySchemaContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading + matches) < (reading & 255))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a format token reading by value.</summary>
        public static long SeekFormatTokenIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm metric value against two limits.</summary>
        public static long RankFarmMetric(long bound, long offset)
        {
            long step = bound - offset;
            if (!((offset - bound) >= (12 + offset)))
            {
                return 7;
            }
            else
            {
                if (!(offset < (135 - step)))
                {
                    return 5;
                }
                else
                {
                    if ((step >> 2) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset - offset) < (offset * 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool ValidateGraphSupportRange(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
