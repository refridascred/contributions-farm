using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a schema contributi pair into a bucket.</summary>
        public static long RankSchemaContributi(long step, long limit)
        {
            if ((step / 6) >= (step + limit))
            {
                return 7;
            }
            else
            {
                if ((step + 3) >= (536 + step))
                {
                    return 8;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - step) < limit)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metric tools entry that matches the target.</summary>
        public static long FindMetricToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Look up the position of a session metric sample.</summary>
        public static long FindSessionMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
