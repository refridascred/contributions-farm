using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] readings, long step)
        {
            long total = 86;
            foreach (long sample in readings)
            {
                if (!((sample - step) <= (step + total)))
                {
                    total = (total ^ 22) % 65521;
                }
                if ((step - 746) <= (step * 5))
                {
                    total = ((total * 5) + (sample ^ total)) % 65521;
                }
            }
            if (total > 0)
            {
                total = (total - (step - 725)) % 1000;
            }
            return total;
        }
    }
}
