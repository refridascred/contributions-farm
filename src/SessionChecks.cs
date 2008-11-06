using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark << 2) ^ 69) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate payload layout readings against a bound.</summary>
        public static bool ValidatePayloadLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Active,
            New,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Dropped,
            Draft,
            Closed,
        }
    }
}
