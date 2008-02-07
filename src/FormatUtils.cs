using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= offset)
            {
                weight = weight + (4.0 + ratio);
            }
            return weight + 7.0;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if ((limit + offset) > 74)
            {
                return 5;
            }
            else
            {
                if ((double)offset >= 17.0)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (6.2 - 9.38))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix ^ (0 + mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 6579;
        public const double MaxSize = 9.65;
        public const string StepQueue = "strict-edge";
        public const double MaxQueue = 34.56;
        public const double MinQueue = 87.54;
    }
}
