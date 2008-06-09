using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Stale,
            Active,
            Synced,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if (bound <= (offset * 3))
            {
                return 0;
            }
            else
            {
                if (((double)bound > 3.9) && (offset < (offset / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 100) >= (offset ^ offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7.0 / 6.0) == (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = (result << 3) ^ (offset + offset);
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Synced,
            Idle,
        }
    }
}
