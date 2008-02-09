using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 6800;
        public const long WindowRatio = 5685;
        public const long LimitChannel = 2956;
        public const long WindowInterval = 2253;
        public const string DefaultBudget = "strict";

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = offset;
            if (drift > offset)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)97;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings, long target)
        {
            long carry = -12;
            foreach (long reading in readings)
            {
                if (!((double)target >= (double)75))
                {
                    carry = ((carry * 4) + (target - carry)) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (reading & 1)) % 97;
                }
                if ((reading ^ target) > target)
                {
                    break;
                }
            }
            if (carry < 792)
            {
                carry = ((carry * 4) + ((-75) % 3)) % 65521;
            }
            return carry;
        }
    }
}
