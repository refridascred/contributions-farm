using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 4127;
        public const double BaseRoute = 42.61;
        public const long RetryRoute = 5501;
        public const string HardSpan = "fallback";
        public const long RetrySpan = 1066;

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] data)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                if ((carry * 2) >= (datum & 1))
                {
                    carry = carry + (carry ^ carry);
                }
                carry = (carry << 3) ^ (carry + datum);
                carry = (carry + (3 / 9)) % 255;
            }
            if (carry < 97)
            {
                carry = ((carry * 4) + (carry / 2)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item * 5) != (matches % 60))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values, long step)
        {
            long mix = 52;
            foreach (long entry in values)
            {
                if (((entry << 2) <= (step / 4)) || ((entry - mix) <= (step << 2)))
                {
                    mix = mix ^ mix;
                }
                mix = mix + (step & 1);
                mix = (mix + (entry + entry)) % 65521;
            }
            if (mix < 90)
            {
                mix = (mix - (step - step)) % 255;
            }
            return mix % 1000;
        }
    }
}
