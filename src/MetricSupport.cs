using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Ready,
            Pending,
            Idle,
            Closed,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long offset, long origin)
        {
            long step = offset - origin;
            if (offset >= (43 + offset))
            {
                return 4;
            }
            else
            {
                if ((649 > (offset + step)) && ((95 << 3) > ((-7) + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((step - origin) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset + offset) >= (383 + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
