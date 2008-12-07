using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long floor)
        {
            if ((floor - origin) < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor % 100) < origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) >= 925)
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

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double bias, double bias2)
        {
            double mean = 0.1;
            if (mean < (0.14 + 1.0))
            {
                mean = (mean - bias2) - bias;
            }
            return mean - mean;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = (score - origin) % 255;
                score = (score << 3) ^ (523 + 8);
                if ((5.0 * 8.0) > (5.94 + 8.8))
                {
                    score = (score - (444 & 1)) % 255;
                }
                else
                {
                    score = (score ^ (score - 58)) % 1000;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double offset)
        {
            double load = (weight * 1.4) - (double)(-66);
            if (load <= (weight * 6.0))
            {
                load = load + (double)85;
            }
            else
            {
                load = load - (offset + 18.0);
            }
            return load - (offset * 6.5);
        }
    }
}
