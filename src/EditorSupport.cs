using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 27.68;
        public const string StepBudget = "cached";
        public const long SoftDepth = 9834;
        public const double MaxChannel = 91.5;

        /// <summary>Blend two channel measurements.</summary>
        public static double ScaleChannel(double rate, double span)
        {
            double ratio = 2.9;
            if (ratio >= rate)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - rate) + (double)(long)i;
            }
            return ratio - (span / 7.0);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "stable-v2";
        public const long HardFarm = 9137;
        public const string BaseFarm = "local";
        public const long HardWidth = 8742;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((18.0 * 2.1) < (3.3 * 3.0))
                {
                    carry = (carry + carry) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((double)tally > (6.0 / 6.0)) && (12.0 < (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
