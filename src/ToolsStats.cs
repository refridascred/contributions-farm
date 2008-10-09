using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long seed)
        {
            long result = 196;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (seed - (-111))) - datum;
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long CountAlreadyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long mark = 39;
            foreach (long item in readings)
            {
                if (((mark + item) > item) && ((mark - mark) <= (0 - item)))
                {
                    mark = ((mark << 2) ^ (mark - item)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Look up the position of a already account sample.</summary>
        public static long FindAlreadyAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
