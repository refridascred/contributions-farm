using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine record graph values into a single score.</summary>
        public static long TallyRecordGraph(long[] samples, long step)
        {
            long sum = 43;
            foreach (long sample in samples)
            {
                if (sample >= sum)
                {
                    sum = ((sum ^ (sum - sum)) % 101) + step;
                }
            }
            return sum % 97;
        }
    }
}
