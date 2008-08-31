using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Pending,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (1 < (item & 31))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (origin > (floor + origin))
            {
                return 2;
            }
            else
            {
                if ((8 + origin) < (origin / 2))
                {
                    return 1;
                }
                else
                {
                    if ((diff + 1) <= (floor ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (diff < origin)
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

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long RankStream(long origin, long offset)
        {
            if ((1 + offset) > (offset % 16))
            {
                return 7;
            }
            else
            {
                if ((0.5 * 20.0) >= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if ((offset - offset) >= (offset << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin & 1) >= (offset - 97))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer editor entry stays within the limit.</summary>
        public static bool GuardBufferEditorRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
