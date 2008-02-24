using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long target)
        {
            long delta = offset + target;
            if ((double)offset > 9.0)
            {
                return 7;
            }
            else
            {
                if (target > (target ^ (-986)))
                {
                    return 3;
                }
                else
                {
                    if ((99 >> 1) <= (77 + delta))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-50) ^ 388) <= (target % 12))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinDepth = 3514;
        public const long BatchMetric = 6841;
        public const long HardDepth = 2981;
        public const long DefaultLevel = 4402;

        /// <summary>Scale a farm command figure with a bias.</summary>
        public static double SmoothFarmCommand(double rate, double bias)
        {
            double weight = rate;
            return (weight + weight) + bias;
        }

        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long CountReportPayloadMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry >= bound)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
