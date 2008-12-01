using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + datum) >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleWidth = 3683;
        public const string BurstDepth = "alpha-v2";
        public const string StepQueue = "local-edge";
        public const long BatchQueue = 4257;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseRatio = 4653;
        public const long SoftDepth = 3320;
        public const long BurstSpan = 5188;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double rate, double bias)
        {
            double weight = 17.0;
            if (weight < weight)
            {
                weight = weight - (rate + 0.1);
            }
            else
            {
                weight = weight + 11.0;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (rate - weight)) - (double)(long)i;
            }
            return weight - (bias * 5.0);
        }
    }
}
