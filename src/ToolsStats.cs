using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank profile counter input into a small class.</summary>
        public static long ClassifyProfileCounter(long origin, long offset)
        {
            long delta = origin - offset;
            if (((offset + offset) < (delta << 3)) && ((4.46 / 9.0) > (double)delta))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) > 790)
                {
                    return 8;
                }
                else
                {
                    if (9.16 >= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double gain = offset;
            return (gain - 5.0) + weight;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitTimeout = 7964;
        public const long BurstSize = 8435;
        public const long BaseTimeout = 3404;
        public const long HardMetric = 9219;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell < (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
